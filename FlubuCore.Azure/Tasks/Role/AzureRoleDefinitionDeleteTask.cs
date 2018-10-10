
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Role
{
     public partial class AzureRoleDefinitionDeleteTask : ExternalProcessTaskBase<AzureRoleDefinitionDeleteTask>
     {
        
        /// <summary>
        /// Delete a role definition.
        /// </summary>
        public AzureRoleDefinitionDeleteTask(string name = null)
        {
            WithArguments("az role definition delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Custom roles only(vs. build-in ones).
        /// </summary>
        public AzureRoleDefinitionDeleteTask CustomRoleOnly(string customRoleOnly = null)
        {
            WithArguments("--custom-role-only");
            if (!string.IsNullOrEmpty(customRoleOnly))
            {
                 WithArguments(customRoleOnly);
            }

            return this;
        }

        /// <summary>
        /// Use it only if the role or assignment was added at the level of a resource group.
        /// </summary>
        public AzureRoleDefinitionDeleteTask ResourceGroup(string resourceGroup = null)
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
        public AzureRoleDefinitionDeleteTask Scope(string scope = null)
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
