
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageAccountManagementPolicyTask : ExternalProcessTaskBase<AzureStorageAccountManagementPolicyTask>
     {
        
        /// <summary>
        /// Manage storage account management policies.
        /// </summary>
        public AzureStorageAccountManagementPolicyTask()
        {
            WithArguments("az storage account management-policy");
        }

        protected override string Description { get; set; }
        
     }
}
