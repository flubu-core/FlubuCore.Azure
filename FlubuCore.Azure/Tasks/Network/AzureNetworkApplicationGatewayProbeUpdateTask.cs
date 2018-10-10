
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayProbeUpdateTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayProbeUpdateTask>
     {
        
        /// <summary>
        /// Update a probe.
        /// </summary>
        public AzureNetworkApplicationGatewayProbeUpdateTask(string gatewayName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network application-gateway probe update");
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
        public AzureNetworkApplicationGatewayProbeUpdateTask Host(string host = null)
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
        public AzureNetworkApplicationGatewayProbeUpdateTask HostNameFromHttpSettings(string hostNameFromHttpSettings = null)
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
        public AzureNetworkApplicationGatewayProbeUpdateTask Interval(string interval = null)
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
        public AzureNetworkApplicationGatewayProbeUpdateTask MatchBody(string matchBody = null)
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
        public AzureNetworkApplicationGatewayProbeUpdateTask MatchStatusCodes(string matchStatusCodes = null)
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
        public AzureNetworkApplicationGatewayProbeUpdateTask MinServers(string minServers = null)
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
        public AzureNetworkApplicationGatewayProbeUpdateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// The relative path of the probe. Valid paths start from "/".
        /// </summary>
        public AzureNetworkApplicationGatewayProbeUpdateTask Path(string path = null)
        {
            WithArguments("--path");
            if (!string.IsNullOrEmpty(path))
            {
                 WithArguments(path);
            }

            return this;
        }

        /// <summary>
        /// The HTTP settings protocol.
        /// </summary>
        public AzureNetworkApplicationGatewayProbeUpdateTask Protocol(string protocol = null)
        {
            WithArguments("--protocol");
            if (!string.IsNullOrEmpty(protocol))
            {
                 WithArguments(protocol);
            }

            return this;
        }

        /// <summary>
        /// The number of failed probes after which the back end server is marked down.
        /// </summary>
        public AzureNetworkApplicationGatewayProbeUpdateTask Threshold(string threshold = null)
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
        public AzureNetworkApplicationGatewayProbeUpdateTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkApplicationGatewayProbeUpdateTask Add(string add = null)
        {
            WithArguments("--add");
            if (!string.IsNullOrEmpty(add))
            {
                 WithArguments(add);
            }

            return this;
        }

        /// <summary>
        /// When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.
        /// </summary>
        public AzureNetworkApplicationGatewayProbeUpdateTask ForceString(string forceString = null)
        {
            WithArguments("--force-string");
            if (!string.IsNullOrEmpty(forceString))
            {
                 WithArguments(forceString);
            }

            return this;
        }

        /// <summary>
        /// Remove a property or an element from a list.  Example: --remove property.list <indexToRemove> OR --remove propertyToRemove.
        /// </summary>
        public AzureNetworkApplicationGatewayProbeUpdateTask Remove(string remove = null)
        {
            WithArguments("--remove");
            if (!string.IsNullOrEmpty(remove))
            {
                 WithArguments(remove);
            }

            return this;
        }

        /// <summary>
        /// Update an object by specifying a property path and value to set.  Example: --set property1.property2=<value>.
        /// </summary>
        public AzureNetworkApplicationGatewayProbeUpdateTask Set(string set = null)
        {
            WithArguments("--set");
            if (!string.IsNullOrEmpty(set))
            {
                 WithArguments(set);
            }

            return this;
        }
     }
}
