
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageAccountCreateTask : ExternalProcessTaskBase<AzureStorageAccountCreateTask>
     {
        
        /// <summary>
        /// Create a storage account.
        /// </summary>
        public AzureStorageAccountCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az storage account create");
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
        /// The access tier used for billing StandardBlob accounts. Cannot be set for StandardLRS, StandardGRS, StandardRAGRS, or PremiumLRS account types. It is required for StandardBlob accounts during creation.
        /// </summary>
        public AzureStorageAccountCreateTask AccessTier(string accessTier = null)
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
        public AzureStorageAccountCreateTask AssignIdentity(string assignIdentity = null)
        {
            WithArguments("--assign-identity");
            if (!string.IsNullOrEmpty(assignIdentity))
            {
                 WithArguments(assignIdentity);
            }

            return this;
        }

        /// <summary>
        /// User domain assigned to the storage account. Name is the CNAME source.
        /// </summary>
        public AzureStorageAccountCreateTask CustomDomain(string customDomain = null)
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
        public AzureStorageAccountCreateTask EncryptionServices(string encryptionServices = null)
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
        public AzureStorageAccountCreateTask FileAad(string fileAad = null)
        {
            WithArguments("--file-aad");
            if (!string.IsNullOrEmpty(fileAad))
            {
                 WithArguments(fileAad);
            }

            return this;
        }

        /// <summary>
        /// Allows the blob service to exhibit filesystem semantics.
        /// </summary>
        public AzureStorageAccountCreateTask HierarchicalNamespace(string hierarchicalNamespace = null)
        {
            WithArguments("--hierarchical-namespace");
            if (!string.IsNullOrEmpty(hierarchicalNamespace))
            {
                 WithArguments(hierarchicalNamespace);
            }

            return this;
        }

        /// <summary>
        /// Allows https traffic only to storage service.
        /// </summary>
        public AzureStorageAccountCreateTask HttpsOnly(string httpsOnly = null)
        {
            WithArguments("--https-only");
            if (!string.IsNullOrEmpty(httpsOnly))
            {
                 WithArguments(httpsOnly);
            }

            return this;
        }

        /// <summary>
        /// Indicates the type of storage account.
        /// </summary>
        public AzureStorageAccountCreateTask Kind(string kind = null)
        {
            WithArguments("--kind");
            if (!string.IsNullOrEmpty(kind))
            {
                 WithArguments(kind);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureStorageAccountCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// The storage account SKU.
        /// </summary>
        public AzureStorageAccountCreateTask Sku(string sku = null)
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
        public AzureStorageAccountCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Bypass traffic for space-separated uses.
        /// </summary>
        public AzureStorageAccountCreateTask Bypass(string bypass = null)
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
        public AzureStorageAccountCreateTask DefaultAction(string defaultAction = null)
        {
            WithArguments("--default-action");
            if (!string.IsNullOrEmpty(defaultAction))
            {
                 WithArguments(defaultAction);
            }

            return this;
        }
     }
}
