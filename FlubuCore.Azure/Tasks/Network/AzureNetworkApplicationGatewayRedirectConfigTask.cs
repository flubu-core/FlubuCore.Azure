
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayRedirectConfigTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayRedirectConfigTask>
     {
        
        /// <summary>
        /// Manage redirect configurations.
        /// </summary>
        public AzureNetworkApplicationGatewayRedirectConfigTask()
        {
            WithArguments("az network application-gateway redirect-config");
        }

        protected override string Description { get; set; }
        
     }
}
