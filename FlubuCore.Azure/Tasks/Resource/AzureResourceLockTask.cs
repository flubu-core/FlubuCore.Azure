
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Resource
{
     public partial class AzureResourceLockTask : ExternalProcessTaskBase<AzureResourceLockTask>
     {
        
        /// <summary>
        /// Manage Azure resource level locks.
        /// </summary>
        public AzureResourceLockTask()
        {
            WithArguments("az resource lock");
        }

        protected override string Description { get; set; }
        
     }
}
