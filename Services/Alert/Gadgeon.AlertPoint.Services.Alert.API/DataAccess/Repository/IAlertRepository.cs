using Gadgeon.AlertPoint.Services.Alert.API.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gadgeon.AlertPoint.Services.Alert.API.DataAccess.Repository
{
   public interface IAlertRepository
    {
        IEnumerable<AlertDomain> GetAlertDetails();
        void AddAlertDetails(AlertDomain alertDomain);
    }
}
