
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayRuleCreateTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayRuleCreateTask>
     {
        
        /// <summary>
        /// Create a rule.
        /// </summary>
        public AzureNetworkApplicationGatewayRuleCreateTask(string gatewayName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network application-gateway rule create");
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
        /// The name or ID of the backend address pool. If only one exists, omit to use as default.
        /// </summary>
        public AzureNetworkApplicationGatewayRuleCreateTask AddressPool(string addressPool = null)
        {
            WithArguments("--address-pool");
            if (!string.IsNullOrEmpty(addressPool))
            {
                 WithArguments(addressPool);
            }

            return this;
        }

        /// <summary>
        /// The name or ID of the HTTP listener. If only one exists, omit to use as default.
        /// </summary>
        public AzureNetworkApplicationGatewayRuleCreateTask HttpListener(string httpListener = null)
        {
            WithArguments("--http-listener");
            if (!string.IsNullOrEmpty(httpListener))
            {
                 WithArguments(httpListener);
            }

            return this;
        }

        /// <summary>
        /// The name or ID of the HTTP settings. If only one exists, omit to use as default.
        /// </summary>
        public AzureNetworkApplicationGatewayRuleCreateTask HttpSettings(string httpSettings = null)
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
        public AzureNetworkApplicationGatewayRuleCreateTask NoWait(string noWait = null)
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
        public AzureNetworkApplicationGatewayRuleCreateTask RedirectConfig(string redirectConfig = null)
        {
            WithArguments("--redirect-config");
            if (!string.IsNullOrEmpty(redirectConfig))
            {
                 WithArguments(redirectConfig);
            }

            return this;
        }

        /// <summary>
        /// The rule type (Basic, PathBasedRouting).
        /// </summary>
        public AzureNetworkApplicationGatewayRuleCreateTask RuleType(string ruleType = null)
        {
            WithArguments("--rule-type");
            if (!string.IsNullOrEmpty(ruleType))
            {
                 WithArguments(ruleType);
            }

            return this;
        }

        /// <summary>
        /// The name or ID of the URL path map.
        /// </summary>
        public AzureNetworkApplicationGatewayRuleCreateTask UrlPathMap(string urlPathMap = null)
        {
            WithArguments("--url-path-map");
            if (!string.IsNullOrEmpty(urlPathMap))
            {
                 WithArguments(urlPathMap);
            }

            return this;
        }
     }
}
