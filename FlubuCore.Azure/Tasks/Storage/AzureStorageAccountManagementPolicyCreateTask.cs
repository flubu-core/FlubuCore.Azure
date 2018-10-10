
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageAccountManagementPolicyCreateTask : ExternalProcessTaskBase<AzureStorageAccountManagementPolicyCreateTask>
     {
        
        /// <summary>
        /// Creates the data policy rules associated with the specified storage account.
        /// </summary>
        public AzureStorageAccountManagementPolicyCreateTask(string accountName = null ,  string resourceGroup = null)
        {
            WithArguments("az storage account management-policy create");
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
        
        /// <summary>
        /// The Storage Account ManagementPolicies Rules, in JSON format. See more details in: <a href="https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts">https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts</a>.
        /// </summary>
        public AzureStorageAccountManagementPolicyCreateTask Policy(string policy = null)
        {
            WithArguments("--policy");
            if (!string.IsNullOrEmpty(policy))
            {
                 WithArguments(policy);
            }

            return this;
        }
     }
}
