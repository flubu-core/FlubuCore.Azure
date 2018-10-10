
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkNsgRuleUpdateTask : ExternalProcessTaskBase<AzureNetworkNsgRuleUpdateTask>
     {
        
        /// <summary>
        /// Update a network security group rule.
        /// </summary>
        public AzureNetworkNsgRuleUpdateTask(string name = null ,  string nsgName = null ,  string resourceGroup = null)
        {
            WithArguments("az network nsg rule update");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--nsg-name");
            if (!string.IsNullOrEmpty(nsgName))
            {
                 WithArguments(nsgName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        public AzureNetworkNsgRuleUpdateTask Access(string access = null)
        {
            WithArguments("--access");
            if (!string.IsNullOrEmpty(access))
            {
                 WithArguments(access);
            }

            return this;
        }

        public AzureNetworkNsgRuleUpdateTask Direction(string direction = null)
        {
            WithArguments("--direction");
            if (!string.IsNullOrEmpty(direction))
            {
                 WithArguments(direction);
            }

            return this;
        }

        /// <summary>
        /// Rule priority, between 100 (highest priority) and 4096 (lowest priority). Must be unique for each rule in the collection.
        /// </summary>
        public AzureNetworkNsgRuleUpdateTask Priority(string priority = null)
        {
            WithArguments("--priority");
            if (!string.IsNullOrEmpty(priority))
            {
                 WithArguments(priority);
            }

            return this;
        }

        /// <summary>
        /// Network protocol this rule applies to.
        /// </summary>
        public AzureNetworkNsgRuleUpdateTask Protocol(string protocol = null)
        {
            WithArguments("--protocol");
            if (!string.IsNullOrEmpty(protocol))
            {
                 WithArguments(protocol);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of CIDR prefixes or IP ranges. Alternatively, specify ONE of 'VirtualNetwork', 'AzureLoadBalancer', 'Internet' or '*' to match all IPs.
        /// </summary>
        public AzureNetworkNsgRuleUpdateTask DestinationAddressPrefixes(string destinationAddressPrefixes = null)
        {
            WithArguments("--destination-address-prefixes");
            if (!string.IsNullOrEmpty(destinationAddressPrefixes))
            {
                 WithArguments(destinationAddressPrefixes);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of application security group names or IDs.
        /// </summary>
        public AzureNetworkNsgRuleUpdateTask DestinationAsgs(string destinationAsgs = null)
        {
            WithArguments("--destination-asgs");
            if (!string.IsNullOrEmpty(destinationAsgs))
            {
                 WithArguments(destinationAsgs);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of ports or port ranges between 0-65535. Use '*' to match all ports.
        /// </summary>
        public AzureNetworkNsgRuleUpdateTask DestinationPortRanges(string destinationPortRanges = null)
        {
            WithArguments("--destination-port-ranges");
            if (!string.IsNullOrEmpty(destinationPortRanges))
            {
                 WithArguments(destinationPortRanges);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of CIDR prefixes or IP ranges. Alternatively, specify ONE of 'VirtualNetwork', 'AzureLoadBalancer', 'Internet' or '*' to match all IPs.
        /// </summary>
        public AzureNetworkNsgRuleUpdateTask SourceAddressPrefixes(string sourceAddressPrefixes = null)
        {
            WithArguments("--source-address-prefixes");
            if (!string.IsNullOrEmpty(sourceAddressPrefixes))
            {
                 WithArguments(sourceAddressPrefixes);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of application security group names or IDs.
        /// </summary>
        public AzureNetworkNsgRuleUpdateTask SourceAsgs(string sourceAsgs = null)
        {
            WithArguments("--source-asgs");
            if (!string.IsNullOrEmpty(sourceAsgs))
            {
                 WithArguments(sourceAsgs);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of ports or port ranges between 0-65535. Use '*' to match all ports.
        /// </summary>
        public AzureNetworkNsgRuleUpdateTask SourcePortRanges(string sourcePortRanges = null)
        {
            WithArguments("--source-port-ranges");
            if (!string.IsNullOrEmpty(sourcePortRanges))
            {
                 WithArguments(sourcePortRanges);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkNsgRuleUpdateTask Add(string add = null)
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
        public AzureNetworkNsgRuleUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkNsgRuleUpdateTask Remove(string remove = null)
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
        public AzureNetworkNsgRuleUpdateTask Set(string set = null)
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
