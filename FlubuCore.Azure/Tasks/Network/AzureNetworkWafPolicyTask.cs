
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkWafPolicyTask : ExternalProcessTaskBase<AzureNetworkWafPolicyTask>
     {
        
        /// <summary>
        /// Manage WebApplication Firewall (WAF) policies.
        /// </summary>
        public AzureNetworkWafPolicyTask()
        {
            WithArguments("az network waf-policy");
        }

        protected override string Description { get; set; }
        
     }
}
