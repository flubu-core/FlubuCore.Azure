
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayFrontendIpTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayFrontendIpTask>
     {
        
        /// <summary>
        /// Manage frontend IP addresses of an application gateway.
        /// </summary>
        public AzureNetworkApplicationGatewayFrontendIpTask()
        {
            WithArguments("az network application-gateway frontend-ip");
        }

        protected override string Description { get; set; }
        
     }
}
