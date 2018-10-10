
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkWatcherConnectionMonitorStopTask : ExternalProcessTaskBase<AzureNetworkWatcherConnectionMonitorStopTask>
     {
        
        /// <summary>
        /// Stop the specified connection monitor.
        /// </summary>
        public AzureNetworkWatcherConnectionMonitorStopTask(string location = null ,  string name = null)
        {
            WithArguments("az network watcher connection-monitor stop");
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
