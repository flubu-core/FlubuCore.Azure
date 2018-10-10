
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkWafPolicyDeleteTask : ExternalProcessTaskBase<AzureNetworkWafPolicyDeleteTask>
     {
        
        /// <summary>
        /// Delete a WAF policy.
        /// </summary>
        public AzureNetworkWafPolicyDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network waf-policy delete");
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
