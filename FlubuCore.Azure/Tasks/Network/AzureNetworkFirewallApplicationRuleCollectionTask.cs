
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFirewallApplicationRuleCollectionTask : ExternalProcessTaskBase<AzureNetworkFirewallApplicationRuleCollectionTask>
     {
        
        /// <summary>
        /// Manage and configure Azure Firewall application rule collections.
        /// </summary>
        public AzureNetworkFirewallApplicationRuleCollectionTask()
        {
            WithArguments("az network firewall application-rule collection");
        }

        protected override string Description { get; set; }
        
     }
}
