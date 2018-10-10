
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFirewallNetworkRuleTask : ExternalProcessTaskBase<AzureNetworkFirewallNetworkRuleTask>
     {
        
        /// <summary>
        /// Manage and configure Azure Firewall network rules.
        /// </summary>
        public AzureNetworkFirewallNetworkRuleTask()
        {
            WithArguments("az network firewall network-rule");
        }

        protected override string Description { get; set; }
        
     }
}
