
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchAccountCreateTask : ExternalProcessTaskBase<AzureBatchAccountCreateTask>
     {
        
        /// <summary>
        /// Create a Batch account with the specified parameters.
        /// </summary>
        public AzureBatchAccountCreateTask(string location = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az batch account create");
WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

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
        /// The KeyVault name or resource ID to be used for an account with a pool allocation mode of 'User Subscription'.
        /// </summary>
        public AzureBatchAccountCreateTask Keyvault(string keyvault = null)
        {
            WithArguments("--keyvault");
            if (!string.IsNullOrEmpty(keyvault))
            {
                 WithArguments(keyvault);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureBatchAccountCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// The storage account name or resource ID to be used for auto storage.
        /// </summary>
        public AzureBatchAccountCreateTask StorageAccount(string storageAccount = null)
        {
            WithArguments("--storage-account");
            if (!string.IsNullOrEmpty(storageAccount))
            {
                 WithArguments(storageAccount);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format.
        /// </summary>
        public AzureBatchAccountCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }
     }
}
