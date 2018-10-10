
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVnetGatewayRevokedCertTask : ExternalProcessTaskBase<AzureNetworkVnetGatewayRevokedCertTask>
     {
        
        /// <summary>
        /// Manage revoked certificates in a virtual network gateway.
        /// </summary>
        public AzureNetworkVnetGatewayRevokedCertTask()
        {
            WithArguments("az network vnet-gateway revoked-cert");
        }

        protected override string Description { get; set; }
        
     }
}
