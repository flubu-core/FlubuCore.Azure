
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Resource
{
     public partial class AzureResourceTagTask : ExternalProcessTaskBase<AzureResourceTagTask>
     {
        
        /// <summary>
        /// Tag a resource.
        /// </summary>
        public AzureResourceTagTask(string tags = null)
        {
            WithArguments("az resource tag");
WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The api version of the resource (omit for latest).
        /// </summary>
        public AzureResourceTagTask ApiVersion(string apiVersion = null)
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
        public AzureResourceTagTask Ids(string ids = null)
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
        public AzureResourceTagTask Name(string name = null)
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
        public AzureResourceTagTask Namespace(string @namespace = null)
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
        public AzureResourceTagTask Parent(string parent = null)
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
        public AzureResourceTagTask ResourceGroup(string resourceGroup = null)
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
        public AzureResourceTagTask ResourceType(string resourceType = null)
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
