
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Policy
{
     public partial class AzurePolicyAssignmentTask : ExternalProcessTaskBase<AzurePolicyAssignmentTask>
     {
        
        /// <summary>
        /// Manage resource policy assignments.
        /// </summary>
        public AzurePolicyAssignmentTask()
        {
            WithArguments("az policy assignment");
        }

        protected override string Description { get; set; }
        
     }
}
