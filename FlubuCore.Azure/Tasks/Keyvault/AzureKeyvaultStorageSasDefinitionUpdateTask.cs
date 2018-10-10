
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Keyvault
{
     public partial class AzureKeyvaultStorageSasDefinitionUpdateTask : ExternalProcessTaskBase<AzureKeyvaultStorageSasDefinitionUpdateTask>
     {
        
        /// <summary>
        /// Updates the specified attributes associated with the given SAS definition.
        /// </summary>
        public AzureKeyvaultStorageSasDefinitionUpdateTask()
        {
            WithArguments("az keyvault storage sas-definition update");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Add the storage account in a disabled state.
        /// </summary>
        public AzureKeyvaultStorageSasDefinitionUpdateTask Disabled(string disabled = null)
        {
            WithArguments("--disabled");
            if (!string.IsNullOrEmpty(disabled))
            {
                 WithArguments(disabled);
            }

            return this;
        }

        /// <summary>
        /// The type of SAS token the SAS definition will create.
        /// </summary>
        public AzureKeyvaultStorageSasDefinitionUpdateTask SasType(string sasType = null)
        {
            WithArguments("--sas-type");
            if (!string.IsNullOrEmpty(sasType))
            {
                 WithArguments(sasType);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureKeyvaultStorageSasDefinitionUpdateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// The SAS definition token template signed with the key 00000000.  In the case of an account token this is only the sas token itself, for service tokens, the full service endpoint url along with the sas token.  Tokens created according to the SAS definition will have the same properties as the template.
        /// </summary>
        public AzureKeyvaultStorageSasDefinitionUpdateTask TemplateUri(string templateUri = null)
        {
            WithArguments("--template-uri");
            if (!string.IsNullOrEmpty(templateUri))
            {
                 WithArguments(templateUri);
            }

            return this;
        }

        /// <summary>
        /// The validity period of SAS tokens created according to the SAS definition in ISO-8601, such as "PT12H" for 12 hour tokens.
        /// </summary>
        public AzureKeyvaultStorageSasDefinitionUpdateTask ValidityPeriod(string validityPeriod = null)
        {
            WithArguments("--validity-period");
            if (!string.IsNullOrEmpty(validityPeriod))
            {
                 WithArguments(validityPeriod);
            }

            return this;
        }

        /// <summary>
        /// Name to identify the storage account in the vault. Required if --id is not specified.
        /// </summary>
        public AzureKeyvaultStorageSasDefinitionUpdateTask AccountName(string accountName = null)
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
        public AzureKeyvaultStorageSasDefinitionUpdateTask Id(string id = null)
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
        public AzureKeyvaultStorageSasDefinitionUpdateTask Name(string name = null)
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
        public AzureKeyvaultStorageSasDefinitionUpdateTask VaultName(string vaultName = null)
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
