using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gadgeon.AlertPoint.Services.Alert.API.Model
{
    public class AlertModel
    {
        public long AlertID { get; set; }

        public string AlertName { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDateTime { get; set; }
    }
}
