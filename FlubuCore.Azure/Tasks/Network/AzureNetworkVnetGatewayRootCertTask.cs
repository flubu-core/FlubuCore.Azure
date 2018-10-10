
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVnetGatewayRootCertTask : ExternalProcessTaskBase<AzureNetworkVnetGatewayRootCertTask>
     {
        
        /// <summary>
        /// Manage root certificates of a virtual network gateway.
        /// </summary>
        public AzureNetworkVnetGatewayRootCertTask()
        {
            WithArguments("az network vnet-gateway root-cert");
        }

        protected override string Description { get; set; }
        
     }
}
