
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Role
{
     public partial class AzureRoleAssignmentDeleteTask : ExternalProcessTaskBase<AzureRoleAssignmentDeleteTask>
     {
        
        /// <summary>
        /// Delete role assignments.
        /// </summary>
        public AzureRoleAssignmentDeleteTask()
        {
            WithArguments("az role assignment delete");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Represent a user, group, or service principal. supported format: object id, user sign-in name, or service principal name.
        /// </summary>
        public AzureRoleAssignmentDeleteTask Assignee(string assignee = null)
        {
            WithArguments("--assignee");
            if (!string.IsNullOrEmpty(assignee))
            {
                 WithArguments(assignee);
            }

            return this;
        }

        /// <summary>
        /// Space-separated role assignment ids.
        /// </summary>
        public AzureRoleAssignmentDeleteTask Ids(string ids = null)
        {
            WithArguments("--ids");
            if (!string.IsNullOrEmpty(ids))
            {
                 WithArguments(ids);
            }

            return this;
        }

        /// <summary>
        /// Include assignments applied on parent scopes.
        /// </summary>
        public AzureRoleAssignmentDeleteTask IncludeInherited(string includeInherited = null)
        {
            WithArguments("--include-inherited");
            if (!string.IsNullOrEmpty(includeInherited))
            {
                 WithArguments(includeInherited);
            }

            return this;
        }

        /// <summary>
        /// Use it only if the role or assignment was added at the level of a resource group.
        /// </summary>
        public AzureRoleAssignmentDeleteTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Role name or id.
        /// </summary>
        public AzureRoleAssignmentDeleteTask Role(string role = null)
        {
            WithArguments("--role");
            if (!string.IsNullOrEmpty(role))
            {
                 WithArguments(role);
            }

            return this;
        }

        /// <summary>
        /// Scope at which the role assignment or definition applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.
        /// </summary>
        public AzureRoleAssignmentDeleteTask Scope(string scope = null)
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
