
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayAuthCertCreateTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayAuthCertCreateTask>
     {
        
        /// <summary>
        /// Create an authorization certificate.
        /// </summary>
        public AzureNetworkApplicationGatewayAuthCertCreateTask(string certFile = null ,  string gatewayName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network application-gateway auth-cert create");
WithArguments("--cert-file");
            if (!string.IsNullOrEmpty(certFile))
            {
                 WithArguments(certFile);
            }

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
        
        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkApplicationGatewayAuthCertCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }
     }
}
