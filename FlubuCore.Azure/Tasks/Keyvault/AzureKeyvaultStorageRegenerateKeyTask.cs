
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultStorageRegenerateKeyTask : ExternalProcessTaskBase<AzureKeyvaultStorageRegenerateKeyTask>
     {
        
        /// <summary>
        /// Regenerates the specified key value for the given storage account.
        /// </summary>
        public AzureKeyvaultStorageRegenerateKeyTask(string keyName = null)
        {
            WithArguments("az keyvault storage regenerate-key");
WithArguments("--key-name");
            if (!string.IsNullOrEmpty(keyName))
            {
                 WithArguments(keyName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Id of the storage account.  If specified all other 'Id' arguments should be omitted.
        /// </summary>
        public AzureKeyvaultStorageRegenerateKeyTask Id(string id = null)
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
        public AzureKeyvaultStorageRegenerateKeyTask Name(string name = null)
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
        public AzureKeyvaultStorageRegenerateKeyTask VaultName(string vaultName = null)
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
