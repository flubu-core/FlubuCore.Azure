
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Role
{
     public partial class AzureRoleAssignmentTask : ExternalProcessTaskBase<AzureRoleAssignmentTask>
     {
        
        /// <summary>
        /// Manage role assignments.
        /// </summary>
        public AzureRoleAssignmentTask()
        {
            WithArguments("az role assignment");
        }

        protected override string Description { get; set; }
        
     }
}
