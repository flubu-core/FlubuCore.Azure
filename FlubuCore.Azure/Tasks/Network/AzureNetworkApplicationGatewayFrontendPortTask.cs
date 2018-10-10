
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayFrontendPortTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayFrontendPortTask>
     {
        
        /// <summary>
        /// Manage frontend ports of an application gateway.
        /// </summary>
        public AzureNetworkApplicationGatewayFrontendPortTask()
        {
            WithArguments("az network application-gateway frontend-port");
        }

        protected override string Description { get; set; }
        
     }
}
