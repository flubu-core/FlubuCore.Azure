
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayFrontendIpCreateTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayFrontendIpCreateTask>
     {
        
        /// <summary>
        /// Create a frontend IP address.
        /// </summary>
        public AzureNetworkApplicationGatewayFrontendIpCreateTask(string gatewayName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network application-gateway frontend-ip create");
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
        public AzureNetworkApplicationGatewayFrontendIpCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Static private IP address to use.
        /// </summary>
        public AzureNetworkApplicationGatewayFrontendIpCreateTask PrivateIpAddress(string privateIpAddress = null)
        {
            WithArguments("--private-ip-address");
            if (!string.IsNullOrEmpty(privateIpAddress))
            {
                 WithArguments(privateIpAddress);
            }

            return this;
        }

        /// <summary>
        /// The name or ID of the public IP address.
        /// </summary>
        public AzureNetworkApplicationGatewayFrontendIpCreateTask PublicIpAddress(string publicIpAddress = null)
        {
            WithArguments("--public-ip-address");
            if (!string.IsNullOrEmpty(publicIpAddress))
            {
                 WithArguments(publicIpAddress);
            }

            return this;
        }

        /// <summary>
        /// The name or ID of the subnet.
        /// </summary>
        public AzureNetworkApplicationGatewayFrontendIpCreateTask Subnet(string subnet = null)
        {
            WithArguments("--subnet");
            if (!string.IsNullOrEmpty(subnet))
            {
                 WithArguments(subnet);
            }

            return this;
        }

        /// <summary>
        /// The name of the virtual network corresponding to the subnet.
        /// </summary>
        public AzureNetworkApplicationGatewayFrontendIpCreateTask VnetName(string vnetName = null)
        {
            WithArguments("--vnet-name");
            if (!string.IsNullOrEmpty(vnetName))
            {
                 WithArguments(vnetName);
            }

            return this;
        }
     }
}
