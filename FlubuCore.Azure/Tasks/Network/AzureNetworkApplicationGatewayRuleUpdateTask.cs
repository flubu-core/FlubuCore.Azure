
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayRuleUpdateTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayRuleUpdateTask>
     {
        
        /// <summary>
        /// Update a rule.
        /// </summary>
        public AzureNetworkApplicationGatewayRuleUpdateTask(string gatewayName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network application-gateway rule update");
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
        /// The name or ID of the backend address pool.
        /// </summary>
        public AzureNetworkApplicationGatewayRuleUpdateTask AddressPool(string addressPool = null)
        {
            WithArguments("--address-pool");
            if (!string.IsNullOrEmpty(addressPool))
            {
                 WithArguments(addressPool);
            }

            return this;
        }

        /// <summary>
        /// The name or ID of the HTTP listener.
        /// </summary>
        public AzureNetworkApplicationGatewayRuleUpdateTask HttpListener(string httpListener = null)
        {
            WithArguments("--http-listener");
            if (!string.IsNullOrEmpty(httpListener))
            {
                 WithArguments(httpListener);
            }

            return this;
        }

        /// <summary>
        /// The name or ID of the backend HTTP settings.
        /// </summary>
        public AzureNetworkApplicationGatewayRuleUpdateTask HttpSettings(string httpSettings = null)
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
        public AzureNetworkApplicationGatewayRuleUpdateTask NoWait(string noWait = null)
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
        public AzureNetworkApplicationGatewayRuleUpdateTask RedirectConfig(string redirectConfig = null)
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
        public AzureNetworkApplicationGatewayRuleUpdateTask RuleType(string ruleType = null)
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
        public AzureNetworkApplicationGatewayRuleUpdateTask UrlPathMap(string urlPathMap = null)
        {
            WithArguments("--url-path-map");
            if (!string.IsNullOrEmpty(urlPathMap))
            {
                 WithArguments(urlPathMap);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkApplicationGatewayRuleUpdateTask Add(string add = null)
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
        public AzureNetworkApplicationGatewayRuleUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkApplicationGatewayRuleUpdateTask Remove(string remove = null)
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
        public AzureNetworkApplicationGatewayRuleUpdateTask Set(string set = null)
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
