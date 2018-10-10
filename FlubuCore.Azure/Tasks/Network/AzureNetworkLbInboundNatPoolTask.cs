
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLbInboundNatPoolTask : ExternalProcessTaskBase<AzureNetworkLbInboundNatPoolTask>
     {
        
        /// <summary>
        /// Manage inbound NAT address pools of a load balancer.
        /// </summary>
        public AzureNetworkLbInboundNatPoolTask()
        {
            WithArguments("az network lb inbound-nat-pool");
        }

        protected override string Description { get; set; }
        
     }
}
