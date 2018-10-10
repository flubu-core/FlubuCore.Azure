
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultStorageRemoveTask : ExternalProcessTaskBase<AzureKeyvaultStorageRemoveTask>
     {
        
        /// <summary>
        /// Deletes a storage account.
        /// </summary>
        public AzureKeyvaultStorageRemoveTask()
        {
            WithArguments("az keyvault storage remove");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Id of the storage account.  If specified all other 'Id' arguments should be omitted.
        /// </summary>
        public AzureKeyvaultStorageRemoveTask Id(string id = null)
        {
            WithArguments("--id");
            if (!string.IsNullOrEmpty(id))
            {
                 WithArguments(id);
            }

            return this;
        }

        /// <summary>
        /// Name to identify the storage account in the vault. Required if --id is not specified.
        /// </summary>
        public AzureKeyvaultStorageRemoveTask Name(string name = null)
        {
            WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

            return this;
        }

        /// <summary>
        /// Name of the key vault. Required if --id is not specified.
        /// </summary>
        public AzureKeyvaultStorageRemoveTask VaultName(string vaultName = null)
        {
            WithArguments("--vault-name");
            if (!string.IsNullOrEmpty(vaultName))
            {
                 WithArguments(vaultName);
            }

            return this;
        }
     }
}
