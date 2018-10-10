
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkWatcherFlowLogTask : ExternalProcessTaskBase<AzureNetworkWatcherFlowLogTask>
     {
        
        /// <summary>
        /// Manage network security group flow logging.
        /// </summary>
        public AzureNetworkWatcherFlowLogTask()
        {
            WithArguments("az network watcher flow-log");
        }

        protected override string Description { get; set; }
        
     }
}
