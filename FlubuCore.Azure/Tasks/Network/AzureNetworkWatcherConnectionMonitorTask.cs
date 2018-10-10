
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkWatcherConnectionMonitorTask : ExternalProcessTaskBase<AzureNetworkWatcherConnectionMonitorTask>
     {
        
        /// <summary>
        /// Manage connection monitoring between an Azure Virtual Machine and any IP resource.
        /// </summary>
        public AzureNetworkWatcherConnectionMonitorTask()
        {
            WithArguments("az network watcher connection-monitor");
        }

        protected override string Description { get; set; }
        
     }
}
