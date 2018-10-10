
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayUrlPathMapTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayUrlPathMapTask>
     {
        
        /// <summary>
        /// Manage URL path maps of an application gateway.
        /// </summary>
        public AzureNetworkApplicationGatewayUrlPathMapTask()
        {
            WithArguments("az network application-gateway url-path-map");
        }

        protected override string Description { get; set; }
        
     }
}
