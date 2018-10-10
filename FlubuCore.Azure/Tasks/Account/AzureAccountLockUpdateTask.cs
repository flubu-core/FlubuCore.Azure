
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Account
{
     public partial class AzureAccountLockUpdateTask : ExternalProcessTaskBase<AzureAccountLockUpdateTask>
     {
        
        /// <summary>
        /// Update a subscription lock.
        /// </summary>
        public AzureAccountLockUpdateTask()
        {
            WithArguments("az account lock update");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// One or more resource IDs (space-delimited). If provided, no other "Resource Id" arguments should be specified.
        /// </summary>
        public AzureAccountLockUpdateTask Ids(string ids = null)
        {
            WithArguments("--ids");
            if (!string.IsNullOrEmpty(ids))
            {
                 WithArguments(ids);
            }

            return this;
        }

        public AzureAccountLockUpdateTask LockType(string lockType = null)
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
        public AzureAccountLockUpdateTask Name(string name = null)
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
        public AzureAccountLockUpdateTask Notes(string notes = null)
        {
            WithArguments("--notes");
            if (!string.IsNullOrEmpty(notes))
            {
                 WithArguments(notes);
            }

            return this;
        }
     }
}
