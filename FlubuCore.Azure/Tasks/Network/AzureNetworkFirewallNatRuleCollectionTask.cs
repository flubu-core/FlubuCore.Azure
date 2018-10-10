
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFirewallNatRuleCollectionTask : ExternalProcessTaskBase<AzureNetworkFirewallNatRuleCollectionTask>
     {
        
        /// <summary>
        /// Manage and configure Azure Firewall NAT rules.
        /// </summary>
        public AzureNetworkFirewallNatRuleCollectionTask()
        {
            WithArguments("az network firewall nat-rule collection");
        }

        protected override string Description { get; set; }
        
     }
}
