
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFirewallNatRuleTask : ExternalProcessTaskBase<AzureNetworkFirewallNatRuleTask>
     {
        
        /// <summary>
        /// Manage and configure Azure Firewall NAT rules.
        /// </summary>
        public AzureNetworkFirewallNatRuleTask()
        {
            WithArguments("az network firewall nat-rule");
        }

        protected override string Description { get; set; }
        
     }
}
