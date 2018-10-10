
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkWatcherConnectionMonitorStartTask : ExternalProcessTaskBase<AzureNetworkWatcherConnectionMonitorStartTask>
     {
        
        /// <summary>
        /// Start the specified connection monitor.
        /// </summary>
        public AzureNetworkWatcherConnectionMonitorStartTask(string location = null ,  string name = null)
        {
            WithArguments("az network watcher connection-monitor start");
WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
     }
}
