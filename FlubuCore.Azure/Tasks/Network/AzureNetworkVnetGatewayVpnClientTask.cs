
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVnetGatewayVpnClientTask : ExternalProcessTaskBase<AzureNetworkVnetGatewayVpnClientTask>
     {
        
        /// <summary>
        /// Download a VPN client configuration required to connect to Azure via point-to-site.
        /// </summary>
        public AzureNetworkVnetGatewayVpnClientTask()
        {
            WithArguments("az network vnet-gateway vpn-client");
        }

        protected override string Description { get; set; }
        
     }
}
