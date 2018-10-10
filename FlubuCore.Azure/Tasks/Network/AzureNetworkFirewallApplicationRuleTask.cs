
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFirewallApplicationRuleTask : ExternalProcessTaskBase<AzureNetworkFirewallApplicationRuleTask>
     {
        
        /// <summary>
        /// Manage and configure Azure Firewall application rules.
        /// </summary>
        public AzureNetworkFirewallApplicationRuleTask()
        {
            WithArguments("az network firewall application-rule");
        }

        protected override string Description { get; set; }
        
     }
}
