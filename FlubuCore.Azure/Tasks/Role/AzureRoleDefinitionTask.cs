
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Role
{
     public partial class AzureRoleDefinitionTask : ExternalProcessTaskBase<AzureRoleDefinitionTask>
     {
        
        /// <summary>
        /// Manage role definitions.
        /// </summary>
        public AzureRoleDefinitionTask()
        {
            WithArguments("az role definition");
        }

        protected override string Description { get; set; }
        
     }
}
