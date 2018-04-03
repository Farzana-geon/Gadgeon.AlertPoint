using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gadgeon.AlertPoint.Services.Alert.API.DataAccess.Repository;
using Gadgeon.AlertPoint.Services.Alert.API.Domain;
using Gadgeon.AlertPoint.Services.Alert.API.Model;
using Gadgeon.AlertPoint.Utility.ValueObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gadgeon.AlertPoint.Alert.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Alerts")]
    public class AlertsController : Controller
    {
        public IAlertRepository AlertRepository { get; }

        public AlertsController(IAlertRepository alertRepository)
        {
            AlertRepository = alertRepository;
        }
        // GET: api/Alerts
        [HttpGet]
        public IEnumerable<AlertModel> Get()
        {

            var data = AlertRepository.GetAlertDetails();
            if(data==null)
            {
                return null;
            }
            //expected auto mapper
            var alertModel = data.Select(
                x => new AlertModel
                {
                    AlertID= x.AlertID,
                    AlertName =x.AlertName,
                    CreatedBy= x.CreatedBy,
                    CreatedDateTime= x.CreatedDateTime.Value

                });

            return alertModel.ToList();
        }

        // GET: api/Alerts/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Alerts
        [HttpPost]
        public void Post([FromBody]AlertModel value)
        {
            var alert = new AlertDomain();
            alert.AddAlertDetails(value.AlertName, value.CreatedBy, value.CreatedDateTime);
            AlertRepository.AddAlertDetails(alert);
        }
        
        // PUT: api/Alerts/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
