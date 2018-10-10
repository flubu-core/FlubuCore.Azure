
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultStorageAddTask : ExternalProcessTaskBase<AzureKeyvaultStorageAddTask>
     {
        
        /// <summary>
        /// Creates or updates a new storage account.
        /// </summary>
        public AzureKeyvaultStorageAddTask(string activeKeyName = null ,  string resourceId = null ,  string name = null ,  string vaultName = null)
        {
            WithArguments("az keyvault storage add");
WithArguments("--active-key-name");
            if (!string.IsNullOrEmpty(activeKeyName))
            {
                 WithArguments(activeKeyName);
            }

WithArguments("--resource-id");
            if (!string.IsNullOrEmpty(resourceId))
            {
                 WithArguments(resourceId);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--vault-name");
            if (!string.IsNullOrEmpty(vaultName))
            {
                 WithArguments(vaultName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Whether keyvault should manage the storage account for the user.
        /// </summary>
        public AzureKeyvaultStorageAddTask AutoRegenerateKey(string autoRegenerateKey = null)
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
        public AzureKeyvaultStorageAddTask Disabled(string disabled = null)
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
        public AzureKeyvaultStorageAddTask RegenerationPeriod(string regenerationPeriod = null)
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
        public AzureKeyvaultStorageAddTask Tags(string tags = null)
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
