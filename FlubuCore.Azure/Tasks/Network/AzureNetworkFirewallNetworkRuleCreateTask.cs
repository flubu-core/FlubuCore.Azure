
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFirewallNetworkRuleCreateTask : ExternalProcessTaskBase<AzureNetworkFirewallNetworkRuleCreateTask>
     {
        
        /// <summary>
        /// Create an Azure Firewall network rule.
        /// </summary>
        public AzureNetworkFirewallNetworkRuleCreateTask(string destinationAddresses = null ,  string destinationPorts = null ,  string firewallName = null ,  string name = null ,  string protocols = null ,  string resourceGroup = null ,  string sourceAddresses = null ,  string collectionName = null)
        {
            WithArguments("az network firewall network-rule create");
WithArguments("--destination-addresses");
            if (!string.IsNullOrEmpty(destinationAddresses))
            {
                 WithArguments(destinationAddresses);
            }

WithArguments("--destination-ports");
            if (!string.IsNullOrEmpty(destinationPorts))
            {
                 WithArguments(destinationPorts);
            }

WithArguments("--firewall-name");
            if (!string.IsNullOrEmpty(firewallName))
            {
                 WithArguments(firewallName);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--protocols");
            if (!string.IsNullOrEmpty(protocols))
            {
                 WithArguments(protocols);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--source-addresses");
            if (!string.IsNullOrEmpty(sourceAddresses))
            {
                 WithArguments(sourceAddresses);
            }

WithArguments("--collection-name");
            if (!string.IsNullOrEmpty(collectionName))
            {
                 WithArguments(collectionName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The action to apply for the rule collection.
        /// </summary>
        public AzureNetworkFirewallNetworkRuleCreateTask Action(string action = null)
        {
            WithArguments("--action");
            if (!string.IsNullOrEmpty(action))
            {
                 WithArguments(action);
            }

            return this;
        }

        /// <summary>
        /// Priority of the rule collection from 100 (high) to 65000 (low).
        /// </summary>
        public AzureNetworkFirewallNetworkRuleCreateTask Priority(string priority = null)
        {
            WithArguments("--priority");
            if (!string.IsNullOrEmpty(priority))
            {
                 WithArguments(priority);
            }

            return this;
        }
     }
}
