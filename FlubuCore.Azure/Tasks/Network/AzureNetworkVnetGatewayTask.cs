
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVnetGatewayTask : ExternalProcessTaskBase<AzureNetworkVnetGatewayTask>
     {
        
        /// <summary>
        /// Use an Azure Virtual Network Gateway to establish secure, cross-premises connectivity.
        /// </summary>
        public AzureNetworkVnetGatewayTask()
        {
            WithArguments("az network vnet-gateway");
        }

        protected override string Description { get; set; }
        
     }
}
