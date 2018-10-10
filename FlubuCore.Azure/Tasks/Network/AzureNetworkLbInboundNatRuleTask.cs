
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLbInboundNatRuleTask : ExternalProcessTaskBase<AzureNetworkLbInboundNatRuleTask>
     {
        
        /// <summary>
        /// Manage inbound NAT rules of a load balancer.
        /// </summary>
        public AzureNetworkLbInboundNatRuleTask()
        {
            WithArguments("az network lb inbound-nat-rule");
        }

        protected override string Description { get; set; }
        
     }
}
