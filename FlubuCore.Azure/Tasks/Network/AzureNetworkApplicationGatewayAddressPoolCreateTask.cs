
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayAddressPoolCreateTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayAddressPoolCreateTask>
     {
        
        /// <summary>
        /// Create an address pool.
        /// </summary>
        public AzureNetworkApplicationGatewayAddressPoolCreateTask(string gatewayName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network application-gateway address-pool create");
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
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkApplicationGatewayAddressPoolCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of IP addresses or DNS names corresponding to backend servers.
        /// </summary>
        public AzureNetworkApplicationGatewayAddressPoolCreateTask Servers(string servers = null)
        {
            WithArguments("--servers");
            if (!string.IsNullOrEmpty(servers))
            {
                 WithArguments(servers);
            }

            return this;
        }
     }
}
