using Autofac;
using Autofac.Core;
using Gadgeon.AlertPoint.Services.Alert.API.DataAccess.JSON;
using Gadgeon.AlertPoint.Services.Alert.API.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gadgeon.AlertPoint.Alert.API.Autofac
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var jsonFilePath = @"\\NITHIN-KOREDEV\AlertPoint\Alert.json";
            builder.Register(c => new JSONAlertRepository(jsonFilePath)).As<IAlertRepository>();
        }
    }
}
