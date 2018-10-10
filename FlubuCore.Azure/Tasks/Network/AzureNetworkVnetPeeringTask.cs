
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVnetPeeringTask : ExternalProcessTaskBase<AzureNetworkVnetPeeringTask>
     {
        
        /// <summary>
        /// Manage peering connections between Azure Virtual Networks.
        /// </summary>
        public AzureNetworkVnetPeeringTask()
        {
            WithArguments("az network vnet peering");
        }

        protected override string Description { get; set; }
        
     }
}
