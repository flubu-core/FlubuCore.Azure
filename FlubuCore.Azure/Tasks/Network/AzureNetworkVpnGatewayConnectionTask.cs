
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVpnGatewayConnectionTask : ExternalProcessTaskBase<AzureNetworkVpnGatewayConnectionTask>
     {
        
        /// <summary>
        /// Manage VPN gateway connections.
        /// </summary>
        public AzureNetworkVpnGatewayConnectionTask()
        {
            WithArguments("az network vpn-gateway connection");
        }

        protected override string Description { get; set; }
        
     }
}
