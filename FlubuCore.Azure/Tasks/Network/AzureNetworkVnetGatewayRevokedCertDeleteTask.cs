
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVnetGatewayRevokedCertDeleteTask : ExternalProcessTaskBase<AzureNetworkVnetGatewayRevokedCertDeleteTask>
     {
        
        /// <summary>
        /// Delete a revoked certificate.
        /// </summary>
        public AzureNetworkVnetGatewayRevokedCertDeleteTask(string gatewayName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network vnet-gateway revoked-cert delete");
WithArguments("--gateway-name");
            if (!string.IsNullOrEmpty(gatewayName))
            {
                 WithArguments(gatewayName);
            }

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
        
     }
}
