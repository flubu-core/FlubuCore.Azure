
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkExpressRouteGatewayTask : ExternalProcessTaskBase<AzureNetworkExpressRouteGatewayTask>
     {
        
        /// <summary>
        /// Manage ExpressRoute gateways.
        /// </summary>
        public AzureNetworkExpressRouteGatewayTask()
        {
            WithArguments("az network express-route gateway");
        }

        protected override string Description { get; set; }
        
     }
}
