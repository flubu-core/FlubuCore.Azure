
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayProbeCreateTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayProbeCreateTask>
     {
        
        /// <summary>
        /// Create a probe.
        /// </summary>
        public AzureNetworkApplicationGatewayProbeCreateTask(string gatewayName = null ,  string name = null ,  string path = null ,  string protocol = null ,  string resourceGroup = null)
        {
            WithArguments("az network application-gateway probe create");
WithArguments("--gateway-name");
            if (!string.IsNullOrEmpty(gatewayName))
            {
                 WithArguments(gatewayName);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--path");
            if (!string.IsNullOrEmpty(path))
            {
                 WithArguments(path);
            }

WithArguments("--protocol");
            if (!string.IsNullOrEmpty(protocol))
            {
                 WithArguments(protocol);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The name of the host to send the probe.
        /// </summary>
        public AzureNetworkApplicationGatewayProbeCreateTask Host(string host = null)
        {
            WithArguments("--host");
            if (!string.IsNullOrEmpty(host))
            {
                 WithArguments(host);
            }

            return this;
        }

        /// <summary>
        /// Use host header from HTTP settings.
        /// </summary>
        public AzureNetworkApplicationGatewayProbeCreateTask HostNameFromHttpSettings(string hostNameFromHttpSettings = null)
        {
            WithArguments("--host-name-from-http-settings");
            if (!string.IsNullOrEmpty(hostNameFromHttpSettings))
            {
                 WithArguments(hostNameFromHttpSettings);
            }

            return this;
        }

        /// <summary>
        /// The time interval in seconds between consecutive probes.
        /// </summary>
        public AzureNetworkApplicationGatewayProbeCreateTask Interval(string interval = null)
        {
            WithArguments("--interval");
            if (!string.IsNullOrEmpty(interval))
            {
                 WithArguments(interval);
            }

            return this;
        }

        /// <summary>
        /// Body that must be contained in the health response.
        /// </summary>
        public AzureNetworkApplicationGatewayProbeCreateTask MatchBody(string matchBody = null)
        {
            WithArguments("--match-body");
            if (!string.IsNullOrEmpty(matchBody))
            {
                 WithArguments(matchBody);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of allowed ranges of healthy status codes for the health response.
        /// </summary>
        public AzureNetworkApplicationGatewayProbeCreateTask MatchStatusCodes(string matchStatusCodes = null)
        {
            WithArguments("--match-status-codes");
            if (!string.IsNullOrEmpty(matchStatusCodes))
            {
                 WithArguments(matchStatusCodes);
            }

            return this;
        }

        /// <summary>
        /// Minimum number of servers that are always marked healthy.
        /// </summary>
        public AzureNetworkApplicationGatewayProbeCreateTask MinServers(string minServers = null)
        {
            WithArguments("--min-servers");
            if (!string.IsNullOrEmpty(minServers))
            {
                 WithArguments(minServers);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkApplicationGatewayProbeCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// The number of failed probes after which the back end server is marked down.
        /// </summary>
        public AzureNetworkApplicationGatewayProbeCreateTask Threshold(string threshold = null)
        {
            WithArguments("--threshold");
            if (!string.IsNullOrEmpty(threshold))
            {
                 WithArguments(threshold);
            }

            return this;
        }

        /// <summary>
        /// The probe timeout in seconds.
        /// </summary>
        public AzureNetworkApplicationGatewayProbeCreateTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }
     }
}
