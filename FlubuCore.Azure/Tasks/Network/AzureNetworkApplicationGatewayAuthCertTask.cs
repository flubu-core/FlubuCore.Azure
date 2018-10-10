
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayAuthCertTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayAuthCertTask>
     {
        
        /// <summary>
        /// Manage authorization certificates of an application gateway.
        /// </summary>
        public AzureNetworkApplicationGatewayAuthCertTask()
        {
            WithArguments("az network application-gateway auth-cert");
        }

        protected override string Description { get; set; }
        
     }
}
