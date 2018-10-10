
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageAccountManagementPolicyDeleteTask : ExternalProcessTaskBase<AzureStorageAccountManagementPolicyDeleteTask>
     {
        
        /// <summary>
        /// Deletes the data policy rules associated with the specified storage account.
        /// </summary>
        public AzureStorageAccountManagementPolicyDeleteTask(string accountName = null ,  string resourceGroup = null)
        {
            WithArguments("az storage account management-policy delete");
WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
     }
}
