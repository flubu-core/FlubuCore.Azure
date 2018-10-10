
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFirewallNetworkRuleCollectionDeleteTask : ExternalProcessTaskBase<AzureNetworkFirewallNetworkRuleCollectionDeleteTask>
     {
        
        /// <summary>
        /// Delete an Azure Firewall network rule collection.
        /// </summary>
        public AzureNetworkFirewallNetworkRuleCollectionDeleteTask(string collectionName = null ,  string firewallName = null ,  string resourceGroup = null)
        {
            WithArguments("az network firewall network-rule collection delete");
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

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
     }
}
