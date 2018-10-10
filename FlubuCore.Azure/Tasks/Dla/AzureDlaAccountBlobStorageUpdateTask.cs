
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaAccountBlobStorageUpdateTask : ExternalProcessTaskBase<AzureDlaAccountBlobStorageUpdateTask>
     {
        
        /// <summary>
        /// Updates an Azure Storage account linked to the specified Data Lake Analytics account.
        /// </summary>
        public AzureDlaAccountBlobStorageUpdateTask(string accessKey = null ,  string account = null ,  string storageAccountName = null)
        {
            WithArguments("az dla account blob-storage update");
WithArguments("--access-key");
            if (!string.IsNullOrEmpty(accessKey))
            {
                 WithArguments(accessKey);
            }

WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

WithArguments("--storage-account-name");
            if (!string.IsNullOrEmpty(storageAccountName))
            {
                 WithArguments(storageAccountName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// If not specified, will attempt to discover the resource group for the specified Data Lake Analytics account.
        /// </summary>
        public AzureDlaAccountBlobStorageUpdateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// The optional suffix for the storage account.
        /// </summary>
        public AzureDlaAccountBlobStorageUpdateTask Suffix(string suffix = null)
        {
            WithArguments("--suffix");
            if (!string.IsNullOrEmpty(suffix))
            {
                 WithArguments(suffix);
            }

            return this;
        }
     }
}
