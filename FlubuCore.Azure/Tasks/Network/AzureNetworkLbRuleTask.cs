
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLbRuleTask : ExternalProcessTaskBase<AzureNetworkLbRuleTask>
     {
        
        /// <summary>
        /// Manage load balancing rules.
        /// </summary>
        public AzureNetworkLbRuleTask()
        {
            WithArguments("az network lb rule");
        }

        protected override string Description { get; set; }
        
     }
}
