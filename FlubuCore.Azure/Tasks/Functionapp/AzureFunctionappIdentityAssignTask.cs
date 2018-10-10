
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappIdentityAssignTask : ExternalProcessTaskBase<AzureFunctionappIdentityAssignTask>
     {
        
        /// <summary>
        /// Assign or disable managed service identity to the functionapp.
        /// </summary>
        public AzureFunctionappIdentityAssignTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az functionapp identity assign");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Role name or id the managed identity will be assigned.
        /// </summary>
        public AzureFunctionappIdentityAssignTask Role(string role = null)
        {
            WithArguments("--role");
            if (!string.IsNullOrEmpty(role))
            {
                 WithArguments(role);
            }

            return this;
        }

        /// <summary>
        /// The scope the managed identity has access to.
        /// </summary>
        public AzureFunctionappIdentityAssignTask Scope(string scope = null)
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
