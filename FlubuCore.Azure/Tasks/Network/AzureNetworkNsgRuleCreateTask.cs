
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkNsgRuleCreateTask : ExternalProcessTaskBase<AzureNetworkNsgRuleCreateTask>
     {
        
        /// <summary>
        /// Create a network security group rule.
        /// </summary>
        public AzureNetworkNsgRuleCreateTask(string name = null ,  string nsgName = null ,  string priority = null ,  string resourceGroup = null)
        {
            WithArguments("az network nsg rule create");
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

WithArguments("--priority");
            if (!string.IsNullOrEmpty(priority))
            {
                 WithArguments(priority);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        public AzureNetworkNsgRuleCreateTask Access(string access = null)
        {
            WithArguments("--access");
            if (!string.IsNullOrEmpty(access))
            {
                 WithArguments(access);
            }

            return this;
        }

        public AzureNetworkNsgRuleCreateTask Direction(string direction = null)
        {
            WithArguments("--direction");
            if (!string.IsNullOrEmpty(direction))
            {
                 WithArguments(direction);
            }

            return this;
        }

        /// <summary>
        /// Network protocol this rule applies to.
        /// </summary>
        public AzureNetworkNsgRuleCreateTask Protocol(string protocol = null)
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
        public AzureNetworkNsgRuleCreateTask DestinationAddressPrefixes(string destinationAddressPrefixes = null)
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
        public AzureNetworkNsgRuleCreateTask DestinationAsgs(string destinationAsgs = null)
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
        public AzureNetworkNsgRuleCreateTask DestinationPortRanges(string destinationPortRanges = null)
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
        public AzureNetworkNsgRuleCreateTask SourceAddressPrefixes(string sourceAddressPrefixes = null)
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
        public AzureNetworkNsgRuleCreateTask SourceAsgs(string sourceAsgs = null)
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
        public AzureNetworkNsgRuleCreateTask SourcePortRanges(string sourcePortRanges = null)
        {
            WithArguments("--source-port-ranges");
            if (!string.IsNullOrEmpty(sourcePortRanges))
            {
                 WithArguments(sourcePortRanges);
            }

            return this;
        }
     }
}
