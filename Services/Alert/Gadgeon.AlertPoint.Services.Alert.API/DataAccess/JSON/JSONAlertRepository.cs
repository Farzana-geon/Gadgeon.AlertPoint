using Gadgeon.AlertPoint.Services.Alert.API.DataAccess.Repository;
using Gadgeon.AlertPoint.Services.Alert.API.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;

namespace Gadgeon.AlertPoint.Services.Alert.API.DataAccess.JSON
{
    public class JSONAlertRepository : IAlertRepository
    {
        private string FilePath { get; set; }
        public JSONAlertRepository(string filepath)
        {
            FilePath = filepath;
        }

        public IEnumerable<AlertDomain> GetAlertDetails()
        {

            var data = File.ReadAllText(FilePath);
            var alerts = JsonConvert.DeserializeObject<IEnumerable<dynamic>>(data);

            return  Mapper(alerts);//auto mapper pref

        }

        private IEnumerable<AlertDomain> Mapper(IEnumerable<dynamic> alerts)
        {
            IList<AlertDomain> domainData = new List<AlertDomain>();
            foreach (var item in alerts)
            {
                var alertDomain = new AlertDomain(Convert.ToInt64(item.AlertID.Value));
                alertDomain.AddAlertDetails(item.AlertName.Value, item.CreatedBy.Value, DateTime.Parse(item.CreatedDateTime.Value));
                domainData.Add(alertDomain);
               
            }
            return domainData;
        }

        public void AddAlertDetails(AlertDomain alertDomain)
        {

            var data = File.ReadAllText(FilePath);
            var alerts = JsonConvert.DeserializeObject<IList<dynamic>>(data).ToList();

            //expected auto mapper
            dynamic newalert = new ExpandoObject();
            newalert.AlertID = alertDomain.AlertID;
            newalert.AlertName = alertDomain.AlertName;
            newalert.CreatedBy = alertDomain.CreatedBy;
            newalert.CreatedDateTime = alertDomain.CreatedDateTime.Value.ToString();
            alerts.Add(newalert);
            var newdata= JsonConvert.SerializeObject(alerts);
            File.WriteAllText(FilePath,newdata);
        }
    }
}
