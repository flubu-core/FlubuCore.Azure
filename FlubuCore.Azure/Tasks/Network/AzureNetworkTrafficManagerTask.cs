
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkTrafficManagerTask : ExternalProcessTaskBase<AzureNetworkTrafficManagerTask>
     {
        
        /// <summary>
        /// Manage the routing of incoming traffic.
        /// </summary>
        public AzureNetworkTrafficManagerTask()
        {
            WithArguments("az network traffic-manager");
        }

        protected override string Description { get; set; }
        
     }
}
