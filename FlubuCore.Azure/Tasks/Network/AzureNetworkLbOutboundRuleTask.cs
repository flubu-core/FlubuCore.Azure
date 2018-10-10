
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLbOutboundRuleTask : ExternalProcessTaskBase<AzureNetworkLbOutboundRuleTask>
     {
        
        /// <summary>
        /// Manage outbound rules of a load balancer.
        /// </summary>
        public AzureNetworkLbOutboundRuleTask()
        {
            WithArguments("az network lb outbound-rule");
        }

        protected override string Description { get; set; }
        
     }
}
