
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultStorageSasDefinitionCreateTask : ExternalProcessTaskBase<AzureKeyvaultStorageSasDefinitionCreateTask>
     {
        
        /// <summary>
        /// Creates or updates a new SAS definition for the specified storage account.
        /// </summary>
        public AzureKeyvaultStorageSasDefinitionCreateTask(string sasType = null ,  string templateUri = null ,  string validityPeriod = null ,  string accountName = null ,  string name = null ,  string vaultName = null)
        {
            WithArguments("az keyvault storage sas-definition create");
WithArguments("--sas-type");
            if (!string.IsNullOrEmpty(sasType))
            {
                 WithArguments(sasType);
            }

WithArguments("--template-uri");
            if (!string.IsNullOrEmpty(templateUri))
            {
                 WithArguments(templateUri);
            }

WithArguments("--validity-period");
            if (!string.IsNullOrEmpty(validityPeriod))
            {
                 WithArguments(validityPeriod);
            }

WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
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
        /// Add the storage account in a disabled state.
        /// </summary>
        public AzureKeyvaultStorageSasDefinitionCreateTask Disabled(string disabled = null)
        {
            WithArguments("--disabled");
            if (!string.IsNullOrEmpty(disabled))
            {
                 WithArguments(disabled);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureKeyvaultStorageSasDefinitionCreateTask Tags(string tags = null)
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
