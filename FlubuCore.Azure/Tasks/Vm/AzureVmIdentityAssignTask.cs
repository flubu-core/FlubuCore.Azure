
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmIdentityAssignTask : ExternalProcessTaskBase<AzureVmIdentityAssignTask>
     {
        
        /// <summary>
        /// Enable managed service identity on a VM.
        /// </summary>
        public AzureVmIdentityAssignTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vm identity assign");
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
        /// The identities to assign.
        /// </summary>
        public AzureVmIdentityAssignTask Identities(string identities = null)
        {
            WithArguments("--identities");
            if (!string.IsNullOrEmpty(identities))
            {
                 WithArguments(identities);
            }

            return this;
        }

        /// <summary>
        /// Role name or id the system assigned identity will have.
        /// </summary>
        public AzureVmIdentityAssignTask Role(string role = null)
        {
            WithArguments("--role");
            if (!string.IsNullOrEmpty(role))
            {
                 WithArguments(role);
            }

            return this;
        }

        /// <summary>
        /// Scope that the system assigned identity can access.
        /// </summary>
        public AzureVmIdentityAssignTask Scope(string scope = null)
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
