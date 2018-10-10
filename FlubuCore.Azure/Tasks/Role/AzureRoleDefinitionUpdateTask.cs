
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Role
{
     public partial class AzureRoleDefinitionUpdateTask : ExternalProcessTaskBase<AzureRoleDefinitionUpdateTask>
     {
        
        /// <summary>
        /// Update a role definition.
        /// </summary>
        public AzureRoleDefinitionUpdateTask(string roleDefinition = null)
        {
            WithArguments("az role definition update");
WithArguments("--role-definition");
            if (!string.IsNullOrEmpty(roleDefinition))
            {
                 WithArguments(roleDefinition);
            }

        }

        protected override string Description { get; set; }
        
     }
}
