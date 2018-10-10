
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVnetGatewayRevokedCertCreateTask : ExternalProcessTaskBase<AzureNetworkVnetGatewayRevokedCertCreateTask>
     {
        
        /// <summary>
        /// Revoke a certificate.
        /// </summary>
        public AzureNetworkVnetGatewayRevokedCertCreateTask(string gatewayName = null ,  string name = null ,  string resourceGroup = null ,  string thumbprint = null)
        {
            WithArguments("az network vnet-gateway revoked-cert create");
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

WithArguments("--thumbprint");
            if (!string.IsNullOrEmpty(thumbprint))
            {
                 WithArguments(thumbprint);
            }

        }

        protected override string Description { get; set; }
        
     }
}
