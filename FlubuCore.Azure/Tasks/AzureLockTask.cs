
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureLockTask : ExternalProcessTaskBase<AzureLockTask>
     {
        
        /// <summary>
        /// Manage Azure locks.
        /// </summary>
        public AzureLockTask()
        {
            WithArguments("az lock");
        }

        protected override string Description { get; set; }
        
     }
}
