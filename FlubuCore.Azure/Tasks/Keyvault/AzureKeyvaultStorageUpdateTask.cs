
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultStorageUpdateTask : ExternalProcessTaskBase<AzureKeyvaultStorageUpdateTask>
     {
        
        /// <summary>
        /// Updates the specified attributes associated with the given storage account.
        /// </summary>
        public AzureKeyvaultStorageUpdateTask()
        {
            WithArguments("az keyvault storage update");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The current active storage account key name.
        /// </summary>
        public AzureKeyvaultStorageUpdateTask ActiveKeyName(string activeKeyName = null)
        {
            WithArguments("--active-key-name");
            if (!string.IsNullOrEmpty(activeKeyName))
            {
                 WithArguments(activeKeyName);
            }

            return this;
        }

        /// <summary>
        /// Whether keyvault should manage the storage account for the user.
        /// </summary>
        public AzureKeyvaultStorageUpdateTask AutoRegenerateKey(string autoRegenerateKey = null)
        {
            WithArguments("--auto-regenerate-key");
            if (!string.IsNullOrEmpty(autoRegenerateKey))
            {
                 WithArguments(autoRegenerateKey);
            }

            return this;
        }

        /// <summary>
        /// Add the storage account in a disabled state.
        /// </summary>
        public AzureKeyvaultStorageUpdateTask Disabled(string disabled = null)
        {
            WithArguments("--disabled");
            if (!string.IsNullOrEmpty(disabled))
            {
                 WithArguments(disabled);
            }

            return this;
        }

        /// <summary>
        /// The key regeneration time duration specified in ISO-8601 format, such as "P30D" for rotation every 30 days.
        /// </summary>
        public AzureKeyvaultStorageUpdateTask RegenerationPeriod(string regenerationPeriod = null)
        {
            WithArguments("--regeneration-period");
            if (!string.IsNullOrEmpty(regenerationPeriod))
            {
                 WithArguments(regenerationPeriod);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureKeyvaultStorageUpdateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Id of the storage account.  If specified all other 'Id' arguments should be omitted.
        /// </summary>
        public AzureKeyvaultStorageUpdateTask Id(string id = null)
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
        public AzureKeyvaultStorageUpdateTask Name(string name = null)
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
        public AzureKeyvaultStorageUpdateTask VaultName(string vaultName = null)
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
