
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkWatcherConnectionMonitorCreateTask : ExternalProcessTaskBase<AzureNetworkWatcherConnectionMonitorCreateTask>
     {
        
        /// <summary>
        /// Create a connection monitor.
        /// </summary>
        public AzureNetworkWatcherConnectionMonitorCreateTask(string name = null ,  string sourceResource = null)
        {
            WithArguments("az network watcher connection-monitor create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--source-resource");
            if (!string.IsNullOrEmpty(sourceResource))
            {
                 WithArguments(sourceResource);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Create the connection monitor but do not start it immediately.
        /// </summary>
        public AzureNetworkWatcherConnectionMonitorCreateTask DoNotStart(string doNotStart = null)
        {
            WithArguments("--do-not-start");
            if (!string.IsNullOrEmpty(doNotStart))
            {
                 WithArguments(doNotStart);
            }

            return this;
        }

        /// <summary>
        /// Monitoring interval in seconds.
        /// </summary>
        public AzureNetworkWatcherConnectionMonitorCreateTask MonitoringInterval(string monitoringInterval = null)
        {
            WithArguments("--monitoring-interval");
            if (!string.IsNullOrEmpty(monitoringInterval))
            {
                 WithArguments(monitoringInterval);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureNetworkWatcherConnectionMonitorCreateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Port number from which to originate traffic.
        /// </summary>
        public AzureNetworkWatcherConnectionMonitorCreateTask SourcePort(string sourcePort = null)
        {
            WithArguments("--source-port");
            if (!string.IsNullOrEmpty(sourcePort))
            {
                 WithArguments(sourcePort);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureNetworkWatcherConnectionMonitorCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// The IP address or URI at which to receive traffic.
        /// </summary>
        public AzureNetworkWatcherConnectionMonitorCreateTask DestAddress(string destAddress = null)
        {
            WithArguments("--dest-address");
            if (!string.IsNullOrEmpty(destAddress))
            {
                 WithArguments(destAddress);
            }

            return this;
        }

        /// <summary>
        /// Port number on which to receive traffic.
        /// </summary>
        public AzureNetworkWatcherConnectionMonitorCreateTask DestPort(string destPort = null)
        {
            WithArguments("--dest-port");
            if (!string.IsNullOrEmpty(destPort))
            {
                 WithArguments(destPort);
            }

            return this;
        }

        /// <summary>
        /// Currently only Virtual Machines are supported.
        /// </summary>
        public AzureNetworkWatcherConnectionMonitorCreateTask DestResource(string destResource = null)
        {
            WithArguments("--dest-resource");
            if (!string.IsNullOrEmpty(destResource))
            {
                 WithArguments(destResource);
            }

            return this;
        }
     }
}
