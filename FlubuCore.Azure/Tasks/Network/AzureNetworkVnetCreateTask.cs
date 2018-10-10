
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVnetCreateTask : ExternalProcessTaskBase<AzureNetworkVnetCreateTask>
     {
        
        /// <summary>
        /// Create a virtual network.
        /// </summary>
        public AzureNetworkVnetCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network vnet create");
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
        /// Space-separated list of IP address prefixes for the VNet.
        /// </summary>
        public AzureNetworkVnetCreateTask AddressPrefixes(string addressPrefixes = null)
        {
            WithArguments("--address-prefixes");
            if (!string.IsNullOrEmpty(addressPrefixes))
            {
                 WithArguments(addressPrefixes);
            }

            return this;
        }

        /// <summary>
        /// Control whether DDoS protection is enabled.
        /// </summary>
        public AzureNetworkVnetCreateTask DdosProtection(string ddosProtection = null)
        {
            WithArguments("--ddos-protection");
            if (!string.IsNullOrEmpty(ddosProtection))
            {
                 WithArguments(ddosProtection);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of a DDoS protection plan to associate with the VNet.
        /// </summary>
        public AzureNetworkVnetCreateTask DdosProtectionPlan(string ddosProtectionPlan = null)
        {
            WithArguments("--ddos-protection-plan");
            if (!string.IsNullOrEmpty(ddosProtectionPlan))
            {
                 WithArguments(ddosProtectionPlan);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of DNS server IP addresses.
        /// </summary>
        public AzureNetworkVnetCreateTask DnsServers(string dnsServers = null)
        {
            WithArguments("--dns-servers");
            if (!string.IsNullOrEmpty(dnsServers))
            {
                 WithArguments(dnsServers);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureNetworkVnetCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Name of a new subnet to create within the VNet.
        /// </summary>
        public AzureNetworkVnetCreateTask SubnetName(string subnetName = null)
        {
            WithArguments("--subnet-name");
            if (!string.IsNullOrEmpty(subnetName))
            {
                 WithArguments(subnetName);
            }

            return this;
        }

        /// <summary>
        /// IP address prefix for the new subnet. If omitted, automatically reserves a /24 (or as large as available) block within the VNet address space.
        /// </summary>
        public AzureNetworkVnetCreateTask SubnetPrefix(string subnetPrefix = null)
        {
            WithArguments("--subnet-prefix");
            if (!string.IsNullOrEmpty(subnetPrefix))
            {
                 WithArguments(subnetPrefix);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureNetworkVnetCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Enable VM protection for all subnets in the VNet.
        /// </summary>
        public AzureNetworkVnetCreateTask VmProtection(string vmProtection = null)
        {
            WithArguments("--vm-protection");
            if (!string.IsNullOrEmpty(vmProtection))
            {
                 WithArguments(vmProtection);
            }

            return this;
        }
     }
}
