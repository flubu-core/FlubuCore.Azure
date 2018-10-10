
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultStorageSasDefinitionDeleteTask : ExternalProcessTaskBase<AzureKeyvaultStorageSasDefinitionDeleteTask>
     {
        
        /// <summary>
        /// Deletes a SAS definition from a specified storage account.
        /// </summary>
        public AzureKeyvaultStorageSasDefinitionDeleteTask()
        {
            WithArguments("az keyvault storage sas-definition delete");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name to identify the storage account in the vault. Required if --id is not specified.
        /// </summary>
        public AzureKeyvaultStorageSasDefinitionDeleteTask AccountName(string accountName = null)
        {
            WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

            return this;
        }

        /// <summary>
        /// Id of the SAS definition.  If specified all other 'Id' arguments should be omitted.
        /// </summary>
        public AzureKeyvaultStorageSasDefinitionDeleteTask Id(string id = null)
        {
            WithArguments("--id");
            if (!string.IsNullOrEmpty(id))
            {
                 WithArguments(id);
            }

            return this;
        }

        /// <summary>
        /// Name to identify the SAS definition in the vault. Required if --id is not specified.
        /// </summary>
        public AzureKeyvaultStorageSasDefinitionDeleteTask Name(string name = null)
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
        public AzureKeyvaultStorageSasDefinitionDeleteTask VaultName(string vaultName = null)
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
