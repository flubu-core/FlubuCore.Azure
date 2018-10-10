
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayUrlPathMapUpdateTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayUrlPathMapUpdateTask>
     {
        
        /// <summary>
        /// Update a URL path map.
        /// </summary>
        public AzureNetworkApplicationGatewayUrlPathMapUpdateTask(string gatewayName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network application-gateway url-path-map update");
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
        /// The name or ID of the default backend address pool.
        /// </summary>
        public AzureNetworkApplicationGatewayUrlPathMapUpdateTask DefaultAddressPool(string defaultAddressPool = null)
        {
            WithArguments("--default-address-pool");
            if (!string.IsNullOrEmpty(defaultAddressPool))
            {
                 WithArguments(defaultAddressPool);
            }

            return this;
        }

        /// <summary>
        /// The name or ID of the default HTTP settings.
        /// </summary>
        public AzureNetworkApplicationGatewayUrlPathMapUpdateTask DefaultHttpSettings(string defaultHttpSettings = null)
        {
            WithArguments("--default-http-settings");
            if (!string.IsNullOrEmpty(defaultHttpSettings))
            {
                 WithArguments(defaultHttpSettings);
            }

            return this;
        }

        /// <summary>
        /// The name or ID of the default redirect configuration.
        /// </summary>
        public AzureNetworkApplicationGatewayUrlPathMapUpdateTask DefaultRedirectConfig(string defaultRedirectConfig = null)
        {
            WithArguments("--default-redirect-config");
            if (!string.IsNullOrEmpty(defaultRedirectConfig))
            {
                 WithArguments(defaultRedirectConfig);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkApplicationGatewayUrlPathMapUpdateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkApplicationGatewayUrlPathMapUpdateTask Add(string add = null)
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
        public AzureNetworkApplicationGatewayUrlPathMapUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkApplicationGatewayUrlPathMapUpdateTask Remove(string remove = null)
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
        public AzureNetworkApplicationGatewayUrlPathMapUpdateTask Set(string set = null)
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
