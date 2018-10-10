
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkWatcherTroubleshootingTask : ExternalProcessTaskBase<AzureNetworkWatcherTroubleshootingTask>
     {
        
        /// <summary>
        /// Manage Network Watcher troubleshooting sessions.
        /// </summary>
        public AzureNetworkWatcherTroubleshootingTask()
        {
            WithArguments("az network watcher troubleshooting");
        }

        protected override string Description { get; set; }
        
     }
}
