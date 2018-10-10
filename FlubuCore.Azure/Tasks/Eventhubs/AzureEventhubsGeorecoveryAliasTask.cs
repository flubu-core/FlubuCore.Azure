
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventhubs
{
     public partial class AzureEventhubsGeorecoveryAliasTask : ExternalProcessTaskBase<AzureEventhubsGeorecoveryAliasTask>
     {
        
        /// <summary>
        /// Manage Azure Event Hubs Geo Recovery configuration Alias.
        /// </summary>
        public AzureEventhubsGeorecoveryAliasTask()
        {
            WithArguments("az eventhubs georecovery-alias");
        }

        protected override string Description { get; set; }
        
     }
}
