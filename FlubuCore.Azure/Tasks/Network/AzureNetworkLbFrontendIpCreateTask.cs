
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLbFrontendIpCreateTask : ExternalProcessTaskBase<AzureNetworkLbFrontendIpCreateTask>
     {
        
        /// <summary>
        /// Create a frontend IP address.
        /// </summary>
        public AzureNetworkLbFrontendIpCreateTask(string lbName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network lb frontend-ip create");
WithArguments("--lb-name");
            if (!string.IsNullOrEmpty(lbName))
            {
                 WithArguments(lbName);
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
        /// Static private IP address to associate with the configuration.
        /// </summary>
        public AzureNetworkLbFrontendIpCreateTask PrivateIpAddress(string privateIpAddress = null)
        {
            WithArguments("--private-ip-address");
            if (!string.IsNullOrEmpty(privateIpAddress))
            {
                 WithArguments(privateIpAddress);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of the existing public IP to associate with the configuration.
        /// </summary>
        public AzureNetworkLbFrontendIpCreateTask PublicIpAddress(string publicIpAddress = null)
        {
            WithArguments("--public-ip-address");
            if (!string.IsNullOrEmpty(publicIpAddress))
            {
                 WithArguments(publicIpAddress);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of a public IP prefix.
        /// </summary>
        public AzureNetworkLbFrontendIpCreateTask PublicIpPrefix(string publicIpPrefix = null)
        {
            WithArguments("--public-ip-prefix");
            if (!string.IsNullOrEmpty(publicIpPrefix))
            {
                 WithArguments(publicIpPrefix);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of an existing subnet. If name is specified, also specify --vnet-name.
        /// </summary>
        public AzureNetworkLbFrontendIpCreateTask Subnet(string subnet = null)
        {
            WithArguments("--subnet");
            if (!string.IsNullOrEmpty(subnet))
            {
                 WithArguments(subnet);
            }

            return this;
        }

        /// <summary>
        /// The virtual network (VNet) associated with the subnet (Omit if supplying a subnet id).
        /// </summary>
        public AzureNetworkLbFrontendIpCreateTask VnetName(string vnetName = null)
        {
            WithArguments("--vnet-name");
            if (!string.IsNullOrEmpty(vnetName))
            {
                 WithArguments(vnetName);
            }

            return this;
        }

        /// <summary>
        /// Availability zone into which to provision the resource.
        /// </summary>
        public AzureNetworkLbFrontendIpCreateTask Zone(string zone = null)
        {
            WithArguments("--zone");
            if (!string.IsNullOrEmpty(zone))
            {
                 WithArguments(zone);
            }

            return this;
        }
     }
}
