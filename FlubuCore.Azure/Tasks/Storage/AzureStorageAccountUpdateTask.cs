
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageAccountUpdateTask : ExternalProcessTaskBase<AzureStorageAccountUpdateTask>
     {
        
        /// <summary>
        /// Update the properties of a storage account.
        /// </summary>
        public AzureStorageAccountUpdateTask(string name = null)
        {
            WithArguments("az storage account update");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The access tier used for billing StandardBlob accounts. Cannot be set for StandardLRS, StandardGRS, StandardRAGRS, or PremiumLRS account types. It is required for StandardBlob accounts during creation.
        /// </summary>
        public AzureStorageAccountUpdateTask AccessTier(string accessTier = null)
        {
            WithArguments("--access-tier");
            if (!string.IsNullOrEmpty(accessTier))
            {
                 WithArguments(accessTier);
            }

            return this;
        }

        /// <summary>
        /// Generate and assign a new Storage Account Identity for this storage account for use with key management services like Azure KeyVault.
        /// </summary>
        public AzureStorageAccountUpdateTask AssignIdentity(string assignIdentity = null)
        {
            WithArguments("--assign-identity");
            if (!string.IsNullOrEmpty(assignIdentity))
            {
                 WithArguments(assignIdentity);
            }

            return this;
        }

        /// <summary>
        /// User domain assigned to the storage account. Name is the CNAME source. Use "" to clear existing value.
        /// </summary>
        public AzureStorageAccountUpdateTask CustomDomain(string customDomain = null)
        {
            WithArguments("--custom-domain");
            if (!string.IsNullOrEmpty(customDomain))
            {
                 WithArguments(customDomain);
            }

            return this;
        }

        /// <summary>
        /// Specifies which service(s) to encrypt.
        /// </summary>
        public AzureStorageAccountUpdateTask EncryptionServices(string encryptionServices = null)
        {
            WithArguments("--encryption-services");
            if (!string.IsNullOrEmpty(encryptionServices))
            {
                 WithArguments(encryptionServices);
            }

            return this;
        }

        /// <summary>
        /// Allows Azure File Active Directory integration, which will support SMB access to azure files using AAD. Requires AAD domain service setup: "<a href="https://docs.microsoft.com/en-us/azure/storage/files/storage-files-active-directory-enable">https://docs.microsoft.com/en-us/azure/storage/files/storage-files-active-directory-enable</a>".
        /// </summary>
        public AzureStorageAccountUpdateTask FileAad(string fileAad = null)
        {
            WithArguments("--file-aad");
            if (!string.IsNullOrEmpty(fileAad))
            {
                 WithArguments(fileAad);
            }

            return this;
        }

        /// <summary>
        /// Allows https traffic only to storage service.
        /// </summary>
        public AzureStorageAccountUpdateTask HttpsOnly(string httpsOnly = null)
        {
            WithArguments("--https-only");
            if (!string.IsNullOrEmpty(httpsOnly))
            {
                 WithArguments(httpsOnly);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureStorageAccountUpdateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// The storage account SKU.
        /// </summary>
        public AzureStorageAccountUpdateTask Sku(string sku = null)
        {
            WithArguments("--sku");
            if (!string.IsNullOrEmpty(sku))
            {
                 WithArguments(sku);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureStorageAccountUpdateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Specify whether to use indirect CNAME validation.
        /// </summary>
        public AzureStorageAccountUpdateTask UseSubdomain(string useSubdomain = null)
        {
            WithArguments("--use-subdomain");
            if (!string.IsNullOrEmpty(useSubdomain))
            {
                 WithArguments(useSubdomain);
            }

            return this;
        }

        /// <summary>
        /// The name of the KeyVault key.
        /// </summary>
        public AzureStorageAccountUpdateTask EncryptionKeyName(string encryptionKeyName = null)
        {
            WithArguments("--encryption-key-name");
            if (!string.IsNullOrEmpty(encryptionKeyName))
            {
                 WithArguments(encryptionKeyName);
            }

            return this;
        }

        /// <summary>
        /// The default encryption service.
        /// </summary>
        public AzureStorageAccountUpdateTask EncryptionKeySource(string encryptionKeySource = null)
        {
            WithArguments("--encryption-key-source");
            if (!string.IsNullOrEmpty(encryptionKeySource))
            {
                 WithArguments(encryptionKeySource);
            }

            return this;
        }

        /// <summary>
        /// The Uri of the KeyVault.
        /// </summary>
        public AzureStorageAccountUpdateTask EncryptionKeyVault(string encryptionKeyVault = null)
        {
            WithArguments("--encryption-key-vault");
            if (!string.IsNullOrEmpty(encryptionKeyVault))
            {
                 WithArguments(encryptionKeyVault);
            }

            return this;
        }

        /// <summary>
        /// The version of the KeyVault key.
        /// </summary>
        public AzureStorageAccountUpdateTask EncryptionKeyVersion(string encryptionKeyVersion = null)
        {
            WithArguments("--encryption-key-version");
            if (!string.IsNullOrEmpty(encryptionKeyVersion))
            {
                 WithArguments(encryptionKeyVersion);
            }

            return this;
        }

        /// <summary>
        /// Bypass traffic for space-separated uses.
        /// </summary>
        public AzureStorageAccountUpdateTask Bypass(string bypass = null)
        {
            WithArguments("--bypass");
            if (!string.IsNullOrEmpty(bypass))
            {
                 WithArguments(bypass);
            }

            return this;
        }

        /// <summary>
        /// Default action to apply when no rule matches.
        /// </summary>
        public AzureStorageAccountUpdateTask DefaultAction(string defaultAction = null)
        {
            WithArguments("--default-action");
            if (!string.IsNullOrEmpty(defaultAction))
            {
                 WithArguments(defaultAction);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureStorageAccountUpdateTask Add(string add = null)
        {
            WithArguments("--add");
            if (!string.IsNullOrEmpty(add))
            {
                 WithArguments(add);
            }

            return this;
        }

        /// <summary>
        /// When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.
        /// </summary>
        public AzureStorageAccountUpdateTask ForceString(string forceString = null)
        {
            WithArguments("--force-string");
            if (!string.IsNullOrEmpty(forceString))
            {
                 WithArguments(forceString);
            }

            return this;
        }

        /// <summary>
        /// Remove a property or an element from a list.  Example: --remove property.list <indexToRemove> OR --remove propertyToRemove.
        /// </summary>
        public AzureStorageAccountUpdateTask Remove(string remove = null)
        {
            WithArguments("--remove");
            if (!string.IsNullOrEmpty(remove))
            {
                 WithArguments(remove);
            }

            return this;
        }

        /// <summary>
        /// Update an object by specifying a property path and value to set.  Example: --set property1.property2=<value>.
        /// </summary>
        public AzureStorageAccountUpdateTask Set(string set = null)
        {
            WithArguments("--set");
            if (!string.IsNullOrEmpty(set))
            {
                 WithArguments(set);
            }

            return this;
        }
     }
}
