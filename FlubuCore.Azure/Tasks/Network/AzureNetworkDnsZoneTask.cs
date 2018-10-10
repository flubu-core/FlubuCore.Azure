
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDnsZoneTask : ExternalProcessTaskBase<AzureNetworkDnsZoneTask>
     {
        
        /// <summary>
        /// Manage DNS zones.
        /// </summary>
        public AzureNetworkDnsZoneTask()
        {
            WithArguments("az network dns zone");
        }

        protected override string Description { get; set; }
        
     }
}
