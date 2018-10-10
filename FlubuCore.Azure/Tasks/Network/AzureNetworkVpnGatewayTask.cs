
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVpnGatewayTask : ExternalProcessTaskBase<AzureNetworkVpnGatewayTask>
     {
        
        /// <summary>
        /// Manage VPN gateways.
        /// </summary>
        public AzureNetworkVpnGatewayTask()
        {
            WithArguments("az network vpn-gateway");
        }

        protected override string Description { get; set; }
        
     }
}
