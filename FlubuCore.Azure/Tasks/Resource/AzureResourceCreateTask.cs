
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Resource
{
     public partial class AzureResourceCreateTask : ExternalProcessTaskBase<AzureResourceCreateTask>
     {
        
        /// <summary>
        /// Create a resource.
        /// </summary>
        public AzureResourceCreateTask(string properties = null)
        {
            WithArguments("az resource create");
WithArguments("--properties");
            if (!string.IsNullOrEmpty(properties))
            {
                 WithArguments(properties);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Resource ID.
        /// </summary>
        public AzureResourceCreateTask Id(string id = null)
        {
            WithArguments("--id");
            if (!string.IsNullOrEmpty(id))
            {
                 WithArguments(id);
            }

            return this;
        }

        /// <summary>
        /// Indicates that the properties object includes other options such as location, tags, sku, and/or plan.
        /// </summary>
        public AzureResourceCreateTask IsFullObject(string isFullObject = null)
        {
            WithArguments("--is-full-object");
            if (!string.IsNullOrEmpty(isFullObject))
            {
                 WithArguments(isFullObject);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureResourceCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// The api version of the resource (omit for latest).
        /// </summary>
        public AzureResourceCreateTask ApiVersion(string apiVersion = null)
        {
            WithArguments("--api-version");
            if (!string.IsNullOrEmpty(apiVersion))
            {
                 WithArguments(apiVersion);
            }

            return this;
        }

        /// <summary>
        /// The resource name. (Ex: myC).
        /// </summary>
        public AzureResourceCreateTask Name(string name = null)
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
        public AzureResourceCreateTask Namespace(string @namespace = null)
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
        public AzureResourceCreateTask Parent(string parent = null)
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
        public AzureResourceCreateTask ResourceGroup(string resourceGroup = null)
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
        public AzureResourceCreateTask ResourceType(string resourceType = null)
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
