
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkNicIpConfigCreateTask : ExternalProcessTaskBase<AzureNetworkNicIpConfigCreateTask>
     {
        
        /// <summary>
        /// Create an IP configuration.
        /// </summary>
        public AzureNetworkNicIpConfigCreateTask(string name = null ,  string nicName = null ,  string resourceGroup = null)
        {
            WithArguments("az network nic ip-config create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--nic-name");
            if (!string.IsNullOrEmpty(nicName))
            {
                 WithArguments(nicName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Space-separated list of application security groups.
        /// </summary>
        public AzureNetworkNicIpConfigCreateTask ApplicationSecurityGroups(string applicationSecurityGroups = null)
        {
            WithArguments("--application-security-groups");
            if (!string.IsNullOrEmpty(applicationSecurityGroups))
            {
                 WithArguments(applicationSecurityGroups);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of names or IDs of load balancer address pools to associate with the NIC. If names are used, --lb-name must be specified.
        /// </summary>
        public AzureNetworkNicIpConfigCreateTask LbAddressPools(string lbAddressPools = null)
        {
            WithArguments("--lb-address-pools");
            if (!string.IsNullOrEmpty(lbAddressPools))
            {
                 WithArguments(lbAddressPools);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of names or IDs of load balancer inbound NAT rules to associate with the NIC. If names are used, --lb-name must be specified.
        /// </summary>
        public AzureNetworkNicIpConfigCreateTask LbInboundNatRules(string lbInboundNatRules = null)
        {
            WithArguments("--lb-inbound-nat-rules");
            if (!string.IsNullOrEmpty(lbInboundNatRules))
            {
                 WithArguments(lbInboundNatRules);
            }

            return this;
        }

        /// <summary>
        /// The name of the load balancer to use when adding NAT rules or address pools by name (ignored when IDs are specified).
        /// </summary>
        public AzureNetworkNicIpConfigCreateTask LbName(string lbName = null)
        {
            WithArguments("--lb-name");
            if (!string.IsNullOrEmpty(lbName))
            {
                 WithArguments(lbName);
            }

            return this;
        }

        /// <summary>
        /// Set to make this configuration the primary one for the NIC.
        /// </summary>
        public AzureNetworkNicIpConfigCreateTask MakePrimary(string makePrimary = null)
        {
            WithArguments("--make-primary");
            if (!string.IsNullOrEmpty(makePrimary))
            {
                 WithArguments(makePrimary);
            }

            return this;
        }

        /// <summary>
        /// Static private IP address to use.
        /// </summary>
        public AzureNetworkNicIpConfigCreateTask PrivateIpAddress(string privateIpAddress = null)
        {
            WithArguments("--private-ip-address");
            if (!string.IsNullOrEmpty(privateIpAddress))
            {
                 WithArguments(privateIpAddress);
            }

            return this;
        }

        public AzureNetworkNicIpConfigCreateTask PrivateIpAddressVersion(string privateIpAddressVersion = null)
        {
            WithArguments("--private-ip-address-version");
            if (!string.IsNullOrEmpty(privateIpAddressVersion))
            {
                 WithArguments(privateIpAddressVersion);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of the public IP to use.
        /// </summary>
        public AzureNetworkNicIpConfigCreateTask PublicIpAddress(string publicIpAddress = null)
        {
            WithArguments("--public-ip-address");
            if (!string.IsNullOrEmpty(publicIpAddress))
            {
                 WithArguments(publicIpAddress);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of an existing subnet. If name is specified, also specify --vnet-name.
        /// </summary>
        public AzureNetworkNicIpConfigCreateTask Subnet(string subnet = null)
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
        public AzureNetworkNicIpConfigCreateTask VnetName(string vnetName = null)
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
