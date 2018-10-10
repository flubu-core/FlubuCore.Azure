
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Policy
{
     public partial class AzurePolicyAssignmentCreateTask : ExternalProcessTaskBase<AzurePolicyAssignmentCreateTask>
     {
        
        /// <summary>
        /// Create a resource policy assignment.
        /// </summary>
        public AzurePolicyAssignmentCreateTask()
        {
            WithArguments("az policy assignment create");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Display name of the assignment.
        /// </summary>
        public AzurePolicyAssignmentCreateTask DisplayName(string displayName = null)
        {
            WithArguments("--display-name");
            if (!string.IsNullOrEmpty(displayName))
            {
                 WithArguments(displayName);
            }

            return this;
        }

        /// <summary>
        /// Name of the new assignment.
        /// </summary>
        public AzurePolicyAssignmentCreateTask Name(string name = null)
        {
            WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

            return this;
        }

        /// <summary>
        /// Space-separated scopes where the policy assignment does not apply.
        /// </summary>
        public AzurePolicyAssignmentCreateTask NotScopes(string notScopes = null)
        {
            WithArguments("--not-scopes");
            if (!string.IsNullOrEmpty(notScopes))
            {
                 WithArguments(notScopes);
            }

            return this;
        }

        /// <summary>
        /// JSON formatted string or path to file with parameter values of policy rule.
        /// </summary>
        public AzurePolicyAssignmentCreateTask Params(string @params = null)
        {
            WithArguments("--params");
            if (!string.IsNullOrEmpty(@params))
            {
                 WithArguments(@params);
            }

            return this;
        }

        /// <summary>
        /// Name or id of the policy definition.
        /// </summary>
        public AzurePolicyAssignmentCreateTask Policy(string policy = null)
        {
            WithArguments("--policy");
            if (!string.IsNullOrEmpty(policy))
            {
                 WithArguments(policy);
            }

            return this;
        }

        /// <summary>
        /// Name or id of the policy set definition.
        /// </summary>
        public AzurePolicyAssignmentCreateTask PolicySetDefinition(string policySetDefinition = null)
        {
            WithArguments("--policy-set-definition");
            if (!string.IsNullOrEmpty(policySetDefinition))
            {
                 WithArguments(policySetDefinition);
            }

            return this;
        }

        /// <summary>
        /// The resource group where the policy will be applied.
        /// </summary>
        public AzurePolicyAssignmentCreateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Scope at which this policy assignment applies to, e.g., /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333, /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup, or /subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM.
        /// </summary>
        public AzurePolicyAssignmentCreateTask Scope(string scope = null)
        {
            WithArguments("--scope");
            if (!string.IsNullOrEmpty(scope))
            {
                 WithArguments(scope);
            }

            return this;
        }

        /// <summary>
        /// Policy sku.
        /// </summary>
        public AzurePolicyAssignmentCreateTask Sku(string sku = null)
        {
            WithArguments("--sku");
            if (!string.IsNullOrEmpty(sku))
            {
                 WithArguments(sku);
            }

            return this;
        }
     }
}
