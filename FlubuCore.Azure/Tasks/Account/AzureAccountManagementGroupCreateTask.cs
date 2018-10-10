
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Account
{
     public partial class AzureAccountManagementGroupCreateTask : ExternalProcessTaskBase<AzureAccountManagementGroupCreateTask>
     {
        
        /// <summary>
        /// Create a new management group.
        /// </summary>
        public AzureAccountManagementGroupCreateTask(string name = null)
        {
            WithArguments("az account management-group create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Sets the display name of the management group. If null, the group name is set as the display name.
        /// </summary>
        public AzureAccountManagementGroupCreateTask DisplayName(string displayName = null)
        {
            WithArguments("--display-name");
            if (!string.IsNullOrEmpty(displayName))
            {
                 WithArguments(displayName);
            }

            return this;
        }

        /// <summary>
        /// Sets the parent of the management group. Can be the fully qualified id or the name of the management group. If null, the root tenant group is set as the parent.
        /// </summary>
        public AzureAccountManagementGroupCreateTask Parent(string parent = null)
        {
            WithArguments("--parent");
            if (!string.IsNullOrEmpty(parent))
            {
                 WithArguments(parent);
            }

            return this;
        }
     }
}
