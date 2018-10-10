
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusGeorecoveryAliasTask : ExternalProcessTaskBase<AzureServicebusGeorecoveryAliasTask>
     {
        
        /// <summary>
        /// Manage Azure Service Bus Geo-Disaster Recovery Configuration Alias.
        /// </summary>
        public AzureServicebusGeorecoveryAliasTask()
        {
            WithArguments("az servicebus georecovery-alias");
        }

        protected override string Description { get; set; }
        
     }
}
