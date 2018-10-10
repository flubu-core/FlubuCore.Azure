
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkExpressRouteGatewayConnectionTask : ExternalProcessTaskBase<AzureNetworkExpressRouteGatewayConnectionTask>
     {
        
        /// <summary>
        /// Manage ExpressRoute gateway connections.
        /// </summary>
        public AzureNetworkExpressRouteGatewayConnectionTask()
        {
            WithArguments("az network express-route gateway connection");
        }

        protected override string Description { get; set; }
        
     }
}
