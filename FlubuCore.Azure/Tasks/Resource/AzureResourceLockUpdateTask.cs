
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Resource
{
     public partial class AzureResourceLockUpdateTask : ExternalProcessTaskBase<AzureResourceLockUpdateTask>
     {
        
        /// <summary>
        /// Update a resource-level lock.
        /// </summary>
        public AzureResourceLockUpdateTask()
        {
            WithArguments("az resource lock update");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.
        /// </summary>
        public AzureResourceLockUpdateTask Ids(string ids = null)
        {
            WithArguments("--ids");
            if (!string.IsNullOrEmpty(ids))
            {
                 WithArguments(ids);
            }

            return this;
        }

        public AzureResourceLockUpdateTask LockType(string lockType = null)
        {
            WithArguments("--lock-type");
            if (!string.IsNullOrEmpty(lockType))
            {
                 WithArguments(lockType);
            }

            return this;
        }

        /// <summary>
        /// Name of the lock.
        /// </summary>
        public AzureResourceLockUpdateTask Name(string name = null)
        {
            WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

            return this;
        }

        /// <summary>
        /// Notes about this lock.
        /// </summary>
        public AzureResourceLockUpdateTask Notes(string notes = null)
        {
            WithArguments("--notes");
            if (!string.IsNullOrEmpty(notes))
            {
                 WithArguments(notes);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureResourceLockUpdateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Provider namespace (Ex: 'Microsoft.Provider').
        /// </summary>
        public AzureResourceLockUpdateTask Namespace(string @namespace = null)
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
        public AzureResourceLockUpdateTask Parent(string parent = null)
        {
            WithArguments("--parent");
            if (!string.IsNullOrEmpty(parent))
            {
                 WithArguments(parent);
            }

            return this;
        }

        /// <summary>
        /// If an ID is given, other resource arguments should not be given.
        /// </summary>
        public AzureResourceLockUpdateTask Resource(string resource = null)
        {
            WithArguments("--resource");
            if (!string.IsNullOrEmpty(resource))
            {
                 WithArguments(resource);
            }

            return this;
        }

        /// <summary>
        /// The resource type (Ex: 'resC'). Can also accept namespace/type format (Ex: 'Microsoft.Provider/resC').
        /// </summary>
        public AzureResourceLockUpdateTask ResourceType(string resourceType = null)
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
