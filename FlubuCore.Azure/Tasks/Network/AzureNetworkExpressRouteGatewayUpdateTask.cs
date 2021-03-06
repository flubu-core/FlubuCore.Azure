
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkExpressRouteGatewayUpdateTask : ExternalProcessTaskBase<AzureNetworkExpressRouteGatewayUpdateTask>
     {
        
        /// <summary>
        /// Update settings of an ExpressRoute gateway.
        /// </summary>
        public AzureNetworkExpressRouteGatewayUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network express-route gateway update");
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
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureNetworkExpressRouteGatewayUpdateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Maximum number of scale units deployed for gateway.
        /// </summary>
        public AzureNetworkExpressRouteGatewayUpdateTask MaxVal(string maxVal = null)
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
        public AzureNetworkExpressRouteGatewayUpdateTask MinVal(string minVal = null)
        {
            WithArguments("--min-val");
            if (!string.IsNullOrEmpty(minVal))
            {
                 WithArguments(minVal);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkExpressRouteGatewayUpdateTask Add(string add = null)
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
        public AzureNetworkExpressRouteGatewayUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkExpressRouteGatewayUpdateTask Remove(string remove = null)
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
        public AzureNetworkExpressRouteGatewayUpdateTask Set(string set = null)
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
