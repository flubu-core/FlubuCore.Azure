
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Account
{
     public partial class AzureAccountManagementGroupDeleteTask : ExternalProcessTaskBase<AzureAccountManagementGroupDeleteTask>
     {
        
        /// <summary>
        /// Delete an existing management group.
        /// </summary>
        public AzureAccountManagementGroupDeleteTask(string name = null)
        {
            WithArguments("az account management-group delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
     }
}
