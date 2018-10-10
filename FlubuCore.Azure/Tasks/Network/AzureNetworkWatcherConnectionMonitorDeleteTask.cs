
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkWatcherConnectionMonitorDeleteTask : ExternalProcessTaskBase<AzureNetworkWatcherConnectionMonitorDeleteTask>
     {
        
        /// <summary>
        /// Delete a connection monitor for the given region.
        /// </summary>
        public AzureNetworkWatcherConnectionMonitorDeleteTask(string location = null ,  string name = null)
        {
            WithArguments("az network watcher connection-monitor delete");
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
