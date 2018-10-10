
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayRedirectConfigUpdateTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayRedirectConfigUpdateTask>
     {
        
        /// <summary>
        /// Update a redirect configuration.
        /// </summary>
        public AzureNetworkApplicationGatewayRedirectConfigUpdateTask(string gatewayName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network application-gateway redirect-config update");
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
        /// Include path in the redirected url.
        /// </summary>
        public AzureNetworkApplicationGatewayRedirectConfigUpdateTask IncludePath(string includePath = null)
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
        public AzureNetworkApplicationGatewayRedirectConfigUpdateTask IncludeQueryString(string includeQueryString = null)
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
        public AzureNetworkApplicationGatewayRedirectConfigUpdateTask NoWait(string noWait = null)
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
        public AzureNetworkApplicationGatewayRedirectConfigUpdateTask TargetListener(string targetListener = null)
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
        public AzureNetworkApplicationGatewayRedirectConfigUpdateTask TargetUrl(string targetUrl = null)
        {
            WithArguments("--target-url");
            if (!string.IsNullOrEmpty(targetUrl))
            {
                 WithArguments(targetUrl);
            }

            return this;
        }

        /// <summary>
        /// HTTP redirection type.
        /// </summary>
        public AzureNetworkApplicationGatewayRedirectConfigUpdateTask Type(string type = null)
        {
            WithArguments("--type");
            if (!string.IsNullOrEmpty(type))
            {
                 WithArguments(type);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkApplicationGatewayRedirectConfigUpdateTask Add(string add = null)
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
        public AzureNetworkApplicationGatewayRedirectConfigUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkApplicationGatewayRedirectConfigUpdateTask Remove(string remove = null)
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
        public AzureNetworkApplicationGatewayRedirectConfigUpdateTask Set(string set = null)
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
