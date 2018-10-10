
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkExpressRouteGatewayConnectionCreateTask : ExternalProcessTaskBase<AzureNetworkExpressRouteGatewayConnectionCreateTask>
     {
        
        /// <summary>
        /// Create an ExpressRoute gateway connection.
        /// </summary>
        public AzureNetworkExpressRouteGatewayConnectionCreateTask(string gatewayName = null ,  string name = null ,  string resourceGroup = null ,  string peering = null)
        {
            WithArguments("az network express-route gateway connection create");
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

WithArguments("--peering");
            if (!string.IsNullOrEmpty(peering))
            {
                 WithArguments(peering);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Authorization key to establish the connection.
        /// </summary>
        public AzureNetworkExpressRouteGatewayConnectionCreateTask AuthorizationKey(string authorizationKey = null)
        {
            WithArguments("--authorization-key");
            if (!string.IsNullOrEmpty(authorizationKey))
            {
                 WithArguments(authorizationKey);
            }

            return this;
        }

        /// <summary>
        /// Routing weight associated with the connection.
        /// </summary>
        public AzureNetworkExpressRouteGatewayConnectionCreateTask RoutingWeight(string routingWeight = null)
        {
            WithArguments("--routing-weight");
            if (!string.IsNullOrEmpty(routingWeight))
            {
                 WithArguments(routingWeight);
            }

            return this;
        }

        /// <summary>
        /// ExpressRoute circuit name.
        /// </summary>
        public AzureNetworkExpressRouteGatewayConnectionCreateTask CircuitName(string circuitName = null)
        {
            WithArguments("--circuit-name");
            if (!string.IsNullOrEmpty(circuitName))
            {
                 WithArguments(circuitName);
            }

            return this;
        }
     }
}
