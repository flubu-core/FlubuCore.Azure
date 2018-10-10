
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkNicIpConfigUpdateTask : ExternalProcessTaskBase<AzureNetworkNicIpConfigUpdateTask>
     {
        
        /// <summary>
        /// Update an IP configuration.
        /// </summary>
        public AzureNetworkNicIpConfigUpdateTask(string name = null ,  string nicName = null ,  string resourceGroup = null)
        {
            WithArguments("az network nic ip-config update");
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
        public AzureNetworkNicIpConfigUpdateTask ApplicationSecurityGroups(string applicationSecurityGroups = null)
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
        public AzureNetworkNicIpConfigUpdateTask LbAddressPools(string lbAddressPools = null)
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
        public AzureNetworkNicIpConfigUpdateTask LbInboundNatRules(string lbInboundNatRules = null)
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
        public AzureNetworkNicIpConfigUpdateTask LbName(string lbName = null)
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
        public AzureNetworkNicIpConfigUpdateTask MakePrimary(string makePrimary = null)
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
        public AzureNetworkNicIpConfigUpdateTask PrivateIpAddress(string privateIpAddress = null)
        {
            WithArguments("--private-ip-address");
            if (!string.IsNullOrEmpty(privateIpAddress))
            {
                 WithArguments(privateIpAddress);
            }

            return this;
        }

        public AzureNetworkNicIpConfigUpdateTask PrivateIpAddressVersion(string privateIpAddressVersion = null)
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
        public AzureNetworkNicIpConfigUpdateTask PublicIpAddress(string publicIpAddress = null)
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
        public AzureNetworkNicIpConfigUpdateTask Subnet(string subnet = null)
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
        public AzureNetworkNicIpConfigUpdateTask VnetName(string vnetName = null)
        {
            WithArguments("--vnet-name");
            if (!string.IsNullOrEmpty(vnetName))
            {
                 WithArguments(vnetName);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkNicIpConfigUpdateTask Add(string add = null)
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
        public AzureNetworkNicIpConfigUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkNicIpConfigUpdateTask Remove(string remove = null)
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
        public AzureNetworkNicIpConfigUpdateTask Set(string set = null)
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
