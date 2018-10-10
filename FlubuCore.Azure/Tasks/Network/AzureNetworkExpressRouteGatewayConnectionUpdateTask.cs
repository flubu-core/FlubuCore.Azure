
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkExpressRouteGatewayConnectionUpdateTask : ExternalProcessTaskBase<AzureNetworkExpressRouteGatewayConnectionUpdateTask>
     {
        
        /// <summary>
        /// Update an ExpressRoute gateway connection.
        /// </summary>
        public AzureNetworkExpressRouteGatewayConnectionUpdateTask(string gatewayName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network express-route gateway connection update");
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
        /// Authorization key to establish the connection.
        /// </summary>
        public AzureNetworkExpressRouteGatewayConnectionUpdateTask AuthorizationKey(string authorizationKey = null)
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
        public AzureNetworkExpressRouteGatewayConnectionUpdateTask RoutingWeight(string routingWeight = null)
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
        public AzureNetworkExpressRouteGatewayConnectionUpdateTask CircuitName(string circuitName = null)
        {
            WithArguments("--circuit-name");
            if (!string.IsNullOrEmpty(circuitName))
            {
                 WithArguments(circuitName);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of an ExpressRoute peering.
        /// </summary>
        public AzureNetworkExpressRouteGatewayConnectionUpdateTask Peering(string peering = null)
        {
            WithArguments("--peering");
            if (!string.IsNullOrEmpty(peering))
            {
                 WithArguments(peering);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkExpressRouteGatewayConnectionUpdateTask Add(string add = null)
        {
            WithArguments("--add");
            if (!string.IsNullOrEmpty(add))
            {
                 WithArguments(add);
            }

            return this;
        }

        /// <summary>
        /// When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.
        /// </summary>
        public AzureNetworkExpressRouteGatewayConnectionUpdateTask ForceString(string forceString = null)
        {
            WithArguments("--force-string");
            if (!string.IsNullOrEmpty(forceString))
            {
                 WithArguments(forceString);
            }

            return this;
        }

        /// <summary>
        /// Remove a property or an element from a list.  Example: --remove property.list <indexToRemove> OR --remove propertyToRemove.
        /// </summary>
        public AzureNetworkExpressRouteGatewayConnectionUpdateTask Remove(string remove = null)
        {
            WithArguments("--remove");
            if (!string.IsNullOrEmpty(remove))
            {
                 WithArguments(remove);
            }

            return this;
        }

        /// <summary>
        /// Update an object by specifying a property path and value to set.  Example: --set property1.property2=<value>.
        /// </summary>
        public AzureNetworkExpressRouteGatewayConnectionUpdateTask Set(string set = null)
        {
            WithArguments("--set");
            if (!string.IsNullOrEmpty(set))
            {
                 WithArguments(set);
            }

            return this;
        }
     }
}
