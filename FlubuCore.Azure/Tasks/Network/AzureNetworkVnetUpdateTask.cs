
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVnetUpdateTask : ExternalProcessTaskBase<AzureNetworkVnetUpdateTask>
     {
        
        /// <summary>
        /// Update a virtual network.
        /// </summary>
        public AzureNetworkVnetUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network vnet update");
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
        public AzureNetworkVnetUpdateTask AddressPrefixes(string addressPrefixes = null)
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
        public AzureNetworkVnetUpdateTask DdosProtection(string ddosProtection = null)
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
        public AzureNetworkVnetUpdateTask DdosProtectionPlan(string ddosProtectionPlan = null)
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
        public AzureNetworkVnetUpdateTask DnsServers(string dnsServers = null)
        {
            WithArguments("--dns-servers");
            if (!string.IsNullOrEmpty(dnsServers))
            {
                 WithArguments(dnsServers);
            }

            return this;
        }

        /// <summary>
        /// Enable VM protection for all subnets in the VNet.
        /// </summary>
        public AzureNetworkVnetUpdateTask VmProtection(string vmProtection = null)
        {
            WithArguments("--vm-protection");
            if (!string.IsNullOrEmpty(vmProtection))
            {
                 WithArguments(vmProtection);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkVnetUpdateTask Add(string add = null)
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
        public AzureNetworkVnetUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkVnetUpdateTask Remove(string remove = null)
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
        public AzureNetworkVnetUpdateTask Set(string set = null)
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
