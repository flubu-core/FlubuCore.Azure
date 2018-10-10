
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkNicIpConfigInboundNatRuleTask : ExternalProcessTaskBase<AzureNetworkNicIpConfigInboundNatRuleTask>
     {
        
        /// <summary>
        /// Manage inbound NAT rules of an IP configuration.
        /// </summary>
        public AzureNetworkNicIpConfigInboundNatRuleTask()
        {
            WithArguments("az network nic ip-config inbound-nat-rule");
        }

        protected override string Description { get; set; }
        
     }
}
