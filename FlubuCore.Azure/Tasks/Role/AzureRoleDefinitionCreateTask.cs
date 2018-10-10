
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Role
{
     public partial class AzureRoleDefinitionCreateTask : ExternalProcessTaskBase<AzureRoleDefinitionCreateTask>
     {
        
        /// <summary>
        /// Create a custom role definition.
        /// </summary>
        public AzureRoleDefinitionCreateTask(string roleDefinition = null)
        {
            WithArguments("az role definition create");
WithArguments("--role-definition");
            if (!string.IsNullOrEmpty(roleDefinition))
            {
                 WithArguments(roleDefinition);
            }

        }

        protected override string Description { get; set; }
        
     }
}
