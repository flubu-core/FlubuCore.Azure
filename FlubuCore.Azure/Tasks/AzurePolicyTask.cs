
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzurePolicyTask : ExternalProcessTaskBase<AzurePolicyTask>
     {
        
        /// <summary>
        /// Manage resource policies.
        /// </summary>
        public AzurePolicyTask()
        {
            WithArguments("az policy");
        }

        protected override string Description { get; set; }
        
     }
}
