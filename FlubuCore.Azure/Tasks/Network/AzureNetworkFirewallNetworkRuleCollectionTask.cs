
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFirewallNetworkRuleCollectionTask : ExternalProcessTaskBase<AzureNetworkFirewallNetworkRuleCollectionTask>
     {
        
        /// <summary>
        /// Manage and configure Azure Firewall network rule collections.
        /// </summary>
        public AzureNetworkFirewallNetworkRuleCollectionTask()
        {
            WithArguments("az network firewall network-rule collection");
        }

        protected override string Description { get; set; }
        
     }
}
