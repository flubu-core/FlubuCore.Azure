
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayRedirectConfigCreateTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayRedirectConfigCreateTask>
     {
        
        /// <summary>
        /// Create a redirect configuration.
        /// </summary>
        public AzureNetworkApplicationGatewayRedirectConfigCreateTask(string gatewayName = null ,  string name = null ,  string resourceGroup = null ,  string type = null)
        {
            WithArguments("az network application-gateway redirect-config create");
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

WithArguments("--type");
            if (!string.IsNullOrEmpty(type))
            {
                 WithArguments(type);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Include path in the redirected url.
        /// </summary>
        public AzureNetworkApplicationGatewayRedirectConfigCreateTask IncludePath(string includePath = null)
        {
            WithArguments("--include-path");
            if (!string.IsNullOrEmpty(includePath))
            {
                 WithArguments(includePath);
            }

            return this;
        }

        /// <summary>
        /// Include query string in the redirected url.
        /// </summary>
        public AzureNetworkApplicationGatewayRedirectConfigCreateTask IncludeQueryString(string includeQueryString = null)
        {
            WithArguments("--include-query-string");
            if (!string.IsNullOrEmpty(includeQueryString))
            {
                 WithArguments(includeQueryString);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkApplicationGatewayRedirectConfigCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of the HTTP listener to redirect the request to.
        /// </summary>
        public AzureNetworkApplicationGatewayRedirectConfigCreateTask TargetListener(string targetListener = null)
        {
            WithArguments("--target-listener");
            if (!string.IsNullOrEmpty(targetListener))
            {
                 WithArguments(targetListener);
            }

            return this;
        }

        /// <summary>
        /// URL to redirect the request to.
        /// </summary>
        public AzureNetworkApplicationGatewayRedirectConfigCreateTask TargetUrl(string targetUrl = null)
        {
            WithArguments("--target-url");
            if (!string.IsNullOrEmpty(targetUrl))
            {
                 WithArguments(targetUrl);
            }

            return this;
        }
     }
}
