
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkExpressRouteGatewayCreateTask : ExternalProcessTaskBase<AzureNetworkExpressRouteGatewayCreateTask>
     {
        
        /// <summary>
        /// Create an ExpressRoute gateway.
        /// </summary>
        public AzureNetworkExpressRouteGatewayCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network express-route gateway create");
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
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureNetworkExpressRouteGatewayCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureNetworkExpressRouteGatewayCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of the virtual hub to associate with the gateway.
        /// </summary>
        public AzureNetworkExpressRouteGatewayCreateTask VirtualHub(string virtualHub = null)
        {
            WithArguments("--virtual-hub");
            if (!string.IsNullOrEmpty(virtualHub))
            {
                 WithArguments(virtualHub);
            }

            return this;
        }

        /// <summary>
        /// Maximum number of scale units deployed for gateway.
        /// </summary>
        public AzureNetworkExpressRouteGatewayCreateTask MaxVal(string maxVal = null)
        {
            WithArguments("--max-val");
            if (!string.IsNullOrEmpty(maxVal))
            {
                 WithArguments(maxVal);
            }

            return this;
        }

        /// <summary>
        /// Minimum number of scale units deployed for gateway.
        /// </summary>
        public AzureNetworkExpressRouteGatewayCreateTask MinVal(string minVal = null)
        {
            WithArguments("--min-val");
            if (!string.IsNullOrEmpty(minVal))
            {
                 WithArguments(minVal);
            }

            return this;
        }
     }
}
