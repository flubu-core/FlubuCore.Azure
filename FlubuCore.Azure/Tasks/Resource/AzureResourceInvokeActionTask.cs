
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Resource
{
     public partial class AzureResourceInvokeActionTask : ExternalProcessTaskBase<AzureResourceInvokeActionTask>
     {
        
        /// <summary>
        /// Invoke an action on the resource.
        /// </summary>
        public AzureResourceInvokeActionTask(string action = null)
        {
            WithArguments("az resource invoke-action");
WithArguments("--action");
            if (!string.IsNullOrEmpty(action))
            {
                 WithArguments(action);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// JSON encoded parameter arguments for the action that will be passed along in the post request body. Use @{file} to load from a file.
        /// </summary>
        public AzureResourceInvokeActionTask RequestBody(string requestBody = null)
        {
            WithArguments("--request-body");
            if (!string.IsNullOrEmpty(requestBody))
            {
                 WithArguments(requestBody);
            }

            return this;
        }

        /// <summary>
        /// The api version of the resource (omit for latest).
        /// </summary>
        public AzureResourceInvokeActionTask ApiVersion(string apiVersion = null)
        {
            WithArguments("--api-version");
            if (!string.IsNullOrEmpty(apiVersion))
            {
                 WithArguments(apiVersion);
            }

            return this;
        }

        /// <summary>
        /// One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.
        /// </summary>
        public AzureResourceInvokeActionTask Ids(string ids = null)
        {
            WithArguments("--ids");
            if (!string.IsNullOrEmpty(ids))
            {
                 WithArguments(ids);
            }

            return this;
        }

        /// <summary>
        /// The resource name. (Ex: myC).
        /// </summary>
        public AzureResourceInvokeActionTask Name(string name = null)
        {
            WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

            return this;
        }

        /// <summary>
        /// Provider namespace (Ex: 'Microsoft.Provider').
        /// </summary>
        public AzureResourceInvokeActionTask Namespace(string @namespace = null)
        {
            WithArguments("--namespace");
            if (!string.IsNullOrEmpty(@namespace))
            {
                 WithArguments(@namespace);
            }

            return this;
        }

        /// <summary>
        /// The parent path (Ex: 'resA/myA/resB/myB').
        /// </summary>
        public AzureResourceInvokeActionTask Parent(string parent = null)
        {
            WithArguments("--parent");
            if (!string.IsNullOrEmpty(parent))
            {
                 WithArguments(parent);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureResourceInvokeActionTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').
        /// </summary>
        public AzureResourceInvokeActionTask ResourceType(string resourceType = null)
        {
            WithArguments("--resource-type");
            if (!string.IsNullOrEmpty(resourceType))
            {
                 WithArguments(resourceType);
            }

            return this;
        }
     }
}
