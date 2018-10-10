
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Lock
{
     public partial class AzureLockDeleteTask : ExternalProcessTaskBase<AzureLockDeleteTask>
     {
        
        /// <summary>
        /// Delete a lock.
        /// </summary>
        public AzureLockDeleteTask()
        {
            WithArguments("az lock delete");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.
        /// </summary>
        public AzureLockDeleteTask Ids(string ids = null)
        {
            WithArguments("--ids");
            if (!string.IsNullOrEmpty(ids))
            {
                 WithArguments(ids);
            }

            return this;
        }

        /// <summary>
        /// Name of the lock.
        /// </summary>
        public AzureLockDeleteTask Name(string name = null)
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
        public AzureLockDeleteTask Namespace(string @namespace = null)
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
        public AzureLockDeleteTask Parent(string parent = null)
        {
            WithArguments("--parent");
            if (!string.IsNullOrEmpty(parent))
            {
                 WithArguments(parent);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of the resource being locked. If an ID is given, other resource arguments should not be given.
        /// </summary>
        public AzureLockDeleteTask Resource(string resource = null)
        {
            WithArguments("--resource");
            if (!string.IsNullOrEmpty(resource))
            {
                 WithArguments(resource);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureLockDeleteTask ResourceGroup(string resourceGroup = null)
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
        public AzureLockDeleteTask ResourceType(string resourceType = null)
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
