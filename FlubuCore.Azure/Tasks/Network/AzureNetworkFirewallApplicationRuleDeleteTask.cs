
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFirewallApplicationRuleDeleteTask : ExternalProcessTaskBase<AzureNetworkFirewallApplicationRuleDeleteTask>
     {
        
        /// <summary>
        /// Delete an Azure Firewall application rule.
        /// </summary>
        public AzureNetworkFirewallApplicationRuleDeleteTask(string collectionName = null ,  string firewallName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network firewall application-rule delete");
WithArguments("--collection-name");
            if (!string.IsNullOrEmpty(collectionName))
            {
                 WithArguments(collectionName);
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

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
     }
}
