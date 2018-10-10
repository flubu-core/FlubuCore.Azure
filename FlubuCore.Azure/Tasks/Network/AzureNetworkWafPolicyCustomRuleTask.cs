
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkWafPolicyCustomRuleTask : ExternalProcessTaskBase<AzureNetworkWafPolicyCustomRuleTask>
     {
        
        /// <summary>
        /// Manage WAF policy custom rules.
        /// </summary>
        public AzureNetworkWafPolicyCustomRuleTask()
        {
            WithArguments("az network waf-policy custom-rule");
        }

        protected override string Description { get; set; }
        
     }
}
