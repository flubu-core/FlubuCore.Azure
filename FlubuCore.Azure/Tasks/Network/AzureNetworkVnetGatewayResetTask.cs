
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVnetGatewayResetTask : ExternalProcessTaskBase<AzureNetworkVnetGatewayResetTask>
     {
        
        /// <summary>
        /// Reset a virtual network gateway.
        /// </summary>
        public AzureNetworkVnetGatewayResetTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network vnet-gateway reset");
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
        
        /// <summary>
        /// Virtual network gateway vip address supplied to the begin reset of the active-active feature enabled gateway.
        /// </summary>
        public AzureNetworkVnetGatewayResetTask GatewayVip(string gatewayVip = null)
        {
            WithArguments("--gateway-vip");
            if (!string.IsNullOrEmpty(gatewayVip))
            {
                 WithArguments(gatewayVip);
            }

            return this;
        }
     }
}
