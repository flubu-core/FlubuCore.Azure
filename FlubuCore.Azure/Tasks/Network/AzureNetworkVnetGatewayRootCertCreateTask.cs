
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVnetGatewayRootCertCreateTask : ExternalProcessTaskBase<AzureNetworkVnetGatewayRootCertCreateTask>
     {
        
        /// <summary>
        /// Upload a root certificate.
        /// </summary>
        public AzureNetworkVnetGatewayRootCertCreateTask(string gatewayName = null ,  string name = null ,  string publicCertData = null ,  string resourceGroup = null)
        {
            WithArguments("az network vnet-gateway root-cert create");
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

WithArguments("--public-cert-data");
            if (!string.IsNullOrEmpty(publicCertData))
            {
                 WithArguments(publicCertData);
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
