
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayUrlPathMapRuleCreateTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayUrlPathMapRuleCreateTask>
     {
        
        /// <summary>
        /// Create a rule for a URL path map.
        /// </summary>
        public AzureNetworkApplicationGatewayUrlPathMapRuleCreateTask(string gatewayName = null ,  string name = null ,  string pathMapName = null ,  string paths = null ,  string resourceGroup = null)
        {
            WithArguments("az network application-gateway url-path-map rule create");
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

WithArguments("--path-map-name");
            if (!string.IsNullOrEmpty(pathMapName))
            {
                 WithArguments(pathMapName);
            }

WithArguments("--paths");
            if (!string.IsNullOrEmpty(paths))
            {
                 WithArguments(paths);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The name or ID of the backend address pool to use with the created rule.
        /// </summary>
        public AzureNetworkApplicationGatewayUrlPathMapRuleCreateTask AddressPool(string addressPool = null)
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
        public AzureNetworkApplicationGatewayUrlPathMapRuleCreateTask HttpSettings(string httpSettings = null)
        {
            WithArguments("--http-settings");
            if (!string.IsNullOrEmpty(httpSettings))
            {
                 WithArguments(httpSettings);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkApplicationGatewayUrlPathMapRuleCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// The name or ID of the redirect configuration to use with the created rule.
        /// </summary>
        public AzureNetworkApplicationGatewayUrlPathMapRuleCreateTask RedirectConfig(string redirectConfig = null)
        {
            WithArguments("--redirect-config");
            if (!string.IsNullOrEmpty(redirectConfig))
            {
                 WithArguments(redirectConfig);
            }

            return this;
        }
     }
}
