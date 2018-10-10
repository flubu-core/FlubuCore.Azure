
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkWatcherTestConnectivityTask : ExternalProcessTaskBase<AzureNetworkWatcherTestConnectivityTask>
     {
        
        /// <summary>
        /// (PREVIEW) Test if a connection can be established between a Virtual Machine and a given endpoint.
        /// </summary>
        public AzureNetworkWatcherTestConnectivityTask(string sourceResource = null)
        {
            WithArguments("az network watcher test-connectivity");
WithArguments("--source-resource");
            if (!string.IsNullOrEmpty(sourceResource))
            {
                 WithArguments(sourceResource);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Protocol to test on.
        /// </summary>
        public AzureNetworkWatcherTestConnectivityTask Protocol(string protocol = null)
        {
            WithArguments("--protocol");
            if (!string.IsNullOrEmpty(protocol))
            {
                 WithArguments(protocol);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureNetworkWatcherTestConnectivityTask ResourceGroup(string resourceGroup = null)
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
        public AzureNetworkWatcherTestConnectivityTask SourcePort(string sourcePort = null)
        {
            WithArguments("--source-port");
            if (!string.IsNullOrEmpty(sourcePort))
            {
                 WithArguments(sourcePort);
            }

            return this;
        }

        /// <summary>
        /// The IP address or URI at which to receive traffic.
        /// </summary>
        public AzureNetworkWatcherTestConnectivityTask DestAddress(string destAddress = null)
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
        public AzureNetworkWatcherTestConnectivityTask DestPort(string destPort = null)
        {
            WithArguments("--dest-port");
            if (!string.IsNullOrEmpty(destPort))
            {
                 WithArguments(destPort);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of the resource to receive traffic.
        /// </summary>
        public AzureNetworkWatcherTestConnectivityTask DestResource(string destResource = null)
        {
            WithArguments("--dest-resource");
            if (!string.IsNullOrEmpty(destResource))
            {
                 WithArguments(destResource);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of headers in `KEY=VALUE` format.
        /// </summary>
        public AzureNetworkWatcherTestConnectivityTask Headers(string headers = null)
        {
            WithArguments("--headers");
            if (!string.IsNullOrEmpty(headers))
            {
                 WithArguments(headers);
            }

            return this;
        }

        /// <summary>
        /// HTTP method to use.
        /// </summary>
        public AzureNetworkWatcherTestConnectivityTask Method(string method = null)
        {
            WithArguments("--method");
            if (!string.IsNullOrEmpty(method))
            {
                 WithArguments(method);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of HTTP status codes considered valid.
        /// </summary>
        public AzureNetworkWatcherTestConnectivityTask ValidStatusCodes(string validStatusCodes = null)
        {
            WithArguments("--valid-status-codes");
            if (!string.IsNullOrEmpty(validStatusCodes))
            {
                 WithArguments(validStatusCodes);
            }

            return this;
        }
     }
}
