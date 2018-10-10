
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappIdentityAssignTask : ExternalProcessTaskBase<AzureWebappIdentityAssignTask>
     {
        
        /// <summary>
        /// Assign or disable managed service identity to the webapp.
        /// </summary>
        public AzureWebappIdentityAssignTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp identity assign");
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
        public AzureWebappIdentityAssignTask Role(string role = null)
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
        public AzureWebappIdentityAssignTask Scope(string scope = null)
        {
            WithArguments("--scope");
            if (!string.IsNullOrEmpty(scope))
            {
                 WithArguments(scope);
            }

            return this;
        }

        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappIdentityAssignTask Slot(string slot = null)
        {
            WithArguments("--slot");
            if (!string.IsNullOrEmpty(slot))
            {
                 WithArguments(slot);
            }

            return this;
        }
     }
}
