
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFirewallApplicationRuleCreateTask : ExternalProcessTaskBase<AzureNetworkFirewallApplicationRuleCreateTask>
     {
        
        /// <summary>
        /// Create an Azure Firewall application rule.
        /// </summary>
        public AzureNetworkFirewallApplicationRuleCreateTask(string firewallName = null ,  string name = null ,  string protocols = null ,  string resourceGroup = null ,  string collectionName = null)
        {
            WithArguments("az network firewall application-rule create");
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

WithArguments("--collection-name");
            if (!string.IsNullOrEmpty(collectionName))
            {
                 WithArguments(collectionName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Space-separated list of FQDN tags.
        /// </summary>
        public AzureNetworkFirewallApplicationRuleCreateTask FqdnTags(string fqdnTags = null)
        {
            WithArguments("--fqdn-tags");
            if (!string.IsNullOrEmpty(fqdnTags))
            {
                 WithArguments(fqdnTags);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of source IP addresses. Use '*' to match all.
        /// </summary>
        public AzureNetworkFirewallApplicationRuleCreateTask SourceAddresses(string sourceAddresses = null)
        {
            WithArguments("--source-addresses");
            if (!string.IsNullOrEmpty(sourceAddresses))
            {
                 WithArguments(sourceAddresses);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of fully qualified domain names (FDQN).
        /// </summary>
        public AzureNetworkFirewallApplicationRuleCreateTask TargetFqdns(string targetFqdns = null)
        {
            WithArguments("--target-fqdns");
            if (!string.IsNullOrEmpty(targetFqdns))
            {
                 WithArguments(targetFqdns);
            }

            return this;
        }

        /// <summary>
        /// The action to apply for the rule collection.
        /// </summary>
        public AzureNetworkFirewallApplicationRuleCreateTask Action(string action = null)
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
        public AzureNetworkFirewallApplicationRuleCreateTask Priority(string priority = null)
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
