
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFrontDoorRoutingRuleCreateTask : ExternalProcessTaskBase<AzureNetworkFrontDoorRoutingRuleCreateTask>
     {
        
        /// <summary>
        /// Create a FrontDoor routing rule.
        /// </summary>
        public AzureNetworkFrontDoorRoutingRuleCreateTask(string backendPool = null ,  string frontDoorName = null ,  string frontendEndpoints = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network front-door routing-rule create");
WithArguments("--backend-pool");
            if (!string.IsNullOrEmpty(backendPool))
            {
                 WithArguments(backendPool);
            }

WithArguments("--front-door-name");
            if (!string.IsNullOrEmpty(frontDoorName))
            {
                 WithArguments(frontDoorName);
            }

WithArguments("--frontend-endpoints");
            if (!string.IsNullOrEmpty(frontendEndpoints))
            {
                 WithArguments(frontendEndpoints);
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
        /// Space-separated list of protocols to accept. Default: Http.
        /// </summary>
        public AzureNetworkFrontDoorRoutingRuleCreateTask AcceptedProtocols(string acceptedProtocols = null)
        {
            WithArguments("--accepted-protocols");
            if (!string.IsNullOrEmpty(acceptedProtocols))
            {
                 WithArguments(acceptedProtocols);
            }

            return this;
        }

        /// <summary>
        /// Custom path used to rewrite resource paths matched by this rule. Leave empty to use incoming path.
        /// </summary>
        public AzureNetworkFrontDoorRoutingRuleCreateTask CustomForwardingPath(string customForwardingPath = null)
        {
            WithArguments("--custom-forwarding-path");
            if (!string.IsNullOrEmpty(customForwardingPath))
            {
                 WithArguments(customForwardingPath);
            }

            return this;
        }

        /// <summary>
        /// Create in a disabled state.
        /// </summary>
        public AzureNetworkFrontDoorRoutingRuleCreateTask Disabled(string disabled = null)
        {
            WithArguments("--disabled");
            if (!string.IsNullOrEmpty(disabled))
            {
                 WithArguments(disabled);
            }

            return this;
        }

        /// <summary>
        /// Use dynamic compression for cached content.
        /// </summary>
        public AzureNetworkFrontDoorRoutingRuleCreateTask DynamicCompression(string dynamicCompression = null)
        {
            WithArguments("--dynamic-compression");
            if (!string.IsNullOrEmpty(dynamicCompression))
            {
                 WithArguments(dynamicCompression);
            }

            return this;
        }

        /// <summary>
        /// Protocol to use for forwarding traffic.
        /// </summary>
        public AzureNetworkFrontDoorRoutingRuleCreateTask ForwardingProtocol(string forwardingProtocol = null)
        {
            WithArguments("--forwarding-protocol");
            if (!string.IsNullOrEmpty(forwardingProtocol))
            {
                 WithArguments(forwardingProtocol);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of patterns to match. Default: '/*'.
        /// </summary>
        public AzureNetworkFrontDoorRoutingRuleCreateTask Patterns(string patterns = null)
        {
            WithArguments("--patterns");
            if (!string.IsNullOrEmpty(patterns))
            {
                 WithArguments(patterns);
            }

            return this;
        }

        /// <summary>
        /// Treatment of URL query terms when forming the cache key.
        /// </summary>
        public AzureNetworkFrontDoorRoutingRuleCreateTask QueryParameterStripDirective(string queryParameterStripDirective = null)
        {
            WithArguments("--query-parameter-strip-directive");
            if (!string.IsNullOrEmpty(queryParameterStripDirective))
            {
                 WithArguments(queryParameterStripDirective);
            }

            return this;
        }
     }
}
