
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFirewallNatRuleCreateTask : ExternalProcessTaskBase<AzureNetworkFirewallNatRuleCreateTask>
     {
        
        /// <summary>
        /// Create an Azure Firewall NAT rule.
        /// </summary>
        public AzureNetworkFirewallNatRuleCreateTask(string destinationAddresses = null ,  string destinationPorts = null ,  string firewallName = null ,  string name = null ,  string protocols = null ,  string resourceGroup = null ,  string sourceAddresses = null ,  string translatedAddress = null ,  string translatedPort = null ,  string collectionName = null)
        {
            WithArguments("az network firewall nat-rule create");
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

WithArguments("--translated-address");
            if (!string.IsNullOrEmpty(translatedAddress))
            {
                 WithArguments(translatedAddress);
            }

WithArguments("--translated-port");
            if (!string.IsNullOrEmpty(translatedPort))
            {
                 WithArguments(translatedPort);
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
        public AzureNetworkFirewallNatRuleCreateTask Action(string action = null)
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
        public AzureNetworkFirewallNatRuleCreateTask Priority(string priority = null)
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
