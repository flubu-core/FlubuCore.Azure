
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Account
{
     public partial class AzureAccountManagementGroupTask : ExternalProcessTaskBase<AzureAccountManagementGroupTask>
     {
        
        /// <summary>
        /// Manage Azure Management Groups.
        /// </summary>
        public AzureAccountManagementGroupTask()
        {
            WithArguments("az account management-group");
        }

        protected override string Description { get; set; }
        
     }
}
