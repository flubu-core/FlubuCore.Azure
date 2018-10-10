
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkDdosProtectionTask : ExternalProcessTaskBase<AzureNetworkDdosProtectionTask>
     {
        
        /// <summary>
        /// Manage DDoS Protection Plans.
        /// </summary>
        public AzureNetworkDdosProtectionTask()
        {
            WithArguments("az network ddos-protection");
        }

        protected override string Description { get; set; }
        
     }
}
