using Gadgeon.AlertPoint.Utility.ValueObjects;
using System;

namespace Gadgeon.AlertPoint.Services.Alert.API.Domain
{
    public class AlertDomain
    {
        public long AlertID { get;private set; }

        public string AlertName { get;private set; }

        public string CreatedBy { get;private set; }

        public DateTimeGeneral CreatedDateTime { get;private set; }

        public AlertDomain(long alertID)
        {
            //TODO- verify alertID valid or not

            AlertID = alertID;
        }
        public AlertDomain()
        {
            AlertID = Convert.ToInt64(DateTime.Now.ToString("yyyyMMddHHmmss"));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="alertName"></param>
        /// <param name="createdBy"></param>
        /// <param name="createdDateTime">local time</param>
        public void AddAlertDetails(string alertName,string createdBy,DateTime createdDateTime)
        {
            AlertName = alertName;
            CreatedBy = createdBy;
            CreatedDateTime = new DateTimeGeneral(createdDateTime);
        }
    }
}
