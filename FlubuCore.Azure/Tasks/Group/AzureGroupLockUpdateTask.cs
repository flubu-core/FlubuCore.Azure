
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Group
{
     public partial class AzureGroupLockUpdateTask : ExternalProcessTaskBase<AzureGroupLockUpdateTask>
     {
        
        /// <summary>
        /// Update a resource group lock.
        /// </summary>
        public AzureGroupLockUpdateTask()
        {
            WithArguments("az group lock update");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.
        /// </summary>
        public AzureGroupLockUpdateTask Ids(string ids = null)
        {
            WithArguments("--ids");
            if (!string.IsNullOrEmpty(ids))
            {
                 WithArguments(ids);
            }

            return this;
        }

        public AzureGroupLockUpdateTask LockType(string lockType = null)
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
        public AzureGroupLockUpdateTask Name(string name = null)
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
        public AzureGroupLockUpdateTask Notes(string notes = null)
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
        public AzureGroupLockUpdateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }
     }
}
