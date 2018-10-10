
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayUrlPathMapCreateTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayUrlPathMapCreateTask>
     {
        
        /// <summary>
        /// Create a URL path map.
        /// </summary>
        public AzureNetworkApplicationGatewayUrlPathMapCreateTask(string gatewayName = null ,  string name = null ,  string resourceGroup = null ,  string paths = null)
        {
            WithArguments("az network application-gateway url-path-map create");
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

WithArguments("--paths");
            if (!string.IsNullOrEmpty(paths))
            {
                 WithArguments(paths);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The name or ID of the default backend address pool, if different from --address-pool.
        /// </summary>
        public AzureNetworkApplicationGatewayUrlPathMapCreateTask DefaultAddressPool(string defaultAddressPool = null)
        {
            WithArguments("--default-address-pool");
            if (!string.IsNullOrEmpty(defaultAddressPool))
            {
                 WithArguments(defaultAddressPool);
            }

            return this;
        }

        /// <summary>
        /// The name or ID of the default HTTP settings, if different from --http-settings.
        /// </summary>
        public AzureNetworkApplicationGatewayUrlPathMapCreateTask DefaultHttpSettings(string defaultHttpSettings = null)
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
        public AzureNetworkApplicationGatewayUrlPathMapCreateTask DefaultRedirectConfig(string defaultRedirectConfig = null)
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
        public AzureNetworkApplicationGatewayUrlPathMapCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// The name or ID of the backend address pool to use with the created rule.
        /// </summary>
        public AzureNetworkApplicationGatewayUrlPathMapCreateTask AddressPool(string addressPool = null)
        {
            WithArguments("--address-pool");
            if (!string.IsNullOrEmpty(addressPool))
            {
                 WithArguments(addressPool);
            }

            return this;
        }

        /// <summary>
        /// The name or ID of the HTTP settings to use with the created rule.
        /// </summary>
        public AzureNetworkApplicationGatewayUrlPathMapCreateTask HttpSettings(string httpSettings = null)
        {
            WithArguments("--http-settings");
            if (!string.IsNullOrEmpty(httpSettings))
            {
                 WithArguments(httpSettings);
            }

            return this;
        }

        /// <summary>
        /// The name or ID of the redirect configuration to use with the created rule.
        /// </summary>
        public AzureNetworkApplicationGatewayUrlPathMapCreateTask RedirectConfig(string redirectConfig = null)
        {
            WithArguments("--redirect-config");
            if (!string.IsNullOrEmpty(redirectConfig))
            {
                 WithArguments(redirectConfig);
            }

            return this;
        }

        /// <summary>
        /// The name of the url-path-map rule.
        /// </summary>
        public AzureNetworkApplicationGatewayUrlPathMapCreateTask RuleName(string ruleName = null)
        {
            WithArguments("--rule-name");
            if (!string.IsNullOrEmpty(ruleName))
            {
                 WithArguments(ruleName);
            }

            return this;
        }
     }
}
