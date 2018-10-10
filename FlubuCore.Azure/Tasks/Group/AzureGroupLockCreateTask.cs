
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Group
{
     public partial class AzureGroupLockCreateTask : ExternalProcessTaskBase<AzureGroupLockCreateTask>
     {
        
        /// <summary>
        /// Create a resource group lock.
        /// </summary>
        public AzureGroupLockCreateTask(string lockType = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az group lock create");
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

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Notes about this lock.
        /// </summary>
        public AzureGroupLockCreateTask Notes(string notes = null)
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
