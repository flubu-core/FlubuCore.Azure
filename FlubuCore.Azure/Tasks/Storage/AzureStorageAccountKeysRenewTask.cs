
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageAccountKeysRenewTask : ExternalProcessTaskBase<AzureStorageAccountKeysRenewTask>
     {
        
        /// <summary>
        /// Regenerates one of the access keys for the specified storage account.
        /// </summary>
        public AzureStorageAccountKeysRenewTask(string accountName = null ,  string key = null)
        {
            WithArguments("az storage account keys renew");
WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

WithArguments("--key");
            if (!string.IsNullOrEmpty(key))
            {
                 WithArguments(key);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureStorageAccountKeysRenewTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }
     }
}
