
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Group
{
     public partial class AzureGroupLockTask : ExternalProcessTaskBase<AzureGroupLockTask>
     {
        
        /// <summary>
        /// Manage Azure resource group locks.
        /// </summary>
        public AzureGroupLockTask()
        {
            WithArguments("az group lock");
        }

        protected override string Description { get; set; }
        
     }
}
