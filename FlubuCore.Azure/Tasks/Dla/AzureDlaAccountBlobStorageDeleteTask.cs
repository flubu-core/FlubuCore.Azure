
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaAccountBlobStorageDeleteTask : ExternalProcessTaskBase<AzureDlaAccountBlobStorageDeleteTask>
     {
        
        /// <summary>
        /// Updates the specified Data Lake Analytics account to remove an Azure Storage account.
        /// </summary>
        public AzureDlaAccountBlobStorageDeleteTask(string account = null ,  string storageAccountName = null)
        {
            WithArguments("az dla account blob-storage delete");
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
        public AzureDlaAccountBlobStorageDeleteTask ResourceGroup(string resourceGroup = null)
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
