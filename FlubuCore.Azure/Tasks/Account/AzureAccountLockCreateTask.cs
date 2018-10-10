
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Account
{
     public partial class AzureAccountLockCreateTask : ExternalProcessTaskBase<AzureAccountLockCreateTask>
     {
        
        /// <summary>
        /// Create a subscription lock.
        /// </summary>
        public AzureAccountLockCreateTask(string lockType = null ,  string name = null)
        {
            WithArguments("az account lock create");
WithArguments("--lock-type");
            if (!string.IsNullOrEmpty(lockType))
            {
                 WithArguments(lockType);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Notes about this lock.
        /// </summary>
        public AzureAccountLockCreateTask Notes(string notes = null)
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
