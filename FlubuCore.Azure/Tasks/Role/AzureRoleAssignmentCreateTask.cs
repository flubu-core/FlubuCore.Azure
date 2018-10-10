
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Role
{
     public partial class AzureRoleAssignmentCreateTask : ExternalProcessTaskBase<AzureRoleAssignmentCreateTask>
     {
        
        /// <summary>
        /// Create a new role assignment for a user, group, or service principal.
        /// </summary>
        public AzureRoleAssignmentCreateTask(string role = null)
        {
            WithArguments("az role assignment create");
WithArguments("--role");
            if (!string.IsNullOrEmpty(role))
            {
                 WithArguments(role);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Represent a user, group, or service principal. supported format: object id, user sign-in name, or service principal name.
        /// </summary>
        public AzureRoleAssignmentCreateTask Assignee(string assignee = null)
        {
            WithArguments("--assignee");
            if (!string.IsNullOrEmpty(assignee))
            {
                 WithArguments(assignee);
            }

            return this;
        }

        /// <summary>
        /// Assignee's graph object id, such as the 'principal id' from a managed service identity. Use this instead of '--assignee' to bypass graph permission issues.
        /// </summary>
        public AzureRoleAssignmentCreateTask AssigneeObjectId(string assigneeObjectId = null)
        {
            WithArguments("--assignee-object-id");
            if (!string.IsNullOrEmpty(assigneeObjectId))
            {
                 WithArguments(assigneeObjectId);
            }

            return this;
        }

        /// <summary>
        /// Use it only if the role or assignment was added at the level of a resource group.
        /// </summary>
        public AzureRoleAssignmentCreateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Scope at which the role assignment or definition applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.
        /// </summary>
        public AzureRoleAssignmentCreateTask Scope(string scope = null)
        {
            WithArguments("--scope");
            if (!string.IsNullOrEmpty(scope))
            {
                 WithArguments(scope);
            }

            return this;
        }
     }
}
