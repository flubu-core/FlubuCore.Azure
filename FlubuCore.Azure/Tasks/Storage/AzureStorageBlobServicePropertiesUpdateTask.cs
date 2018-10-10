
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageBlobServicePropertiesUpdateTask : ExternalProcessTaskBase<AzureStorageBlobServicePropertiesUpdateTask>
     {
        
        /// <summary>
        /// Update storage blob service properties.
        /// </summary>
        public AzureStorageBlobServicePropertiesUpdateTask()
        {
            WithArguments("az storage blob service-properties update");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The mode in which to run the command. "login" mode will directly use your login credentials for the authentication. The legacy "key" mode will attempt to query for an account key if no authentication parameters for the account are provided. Environment variable: AZURE_STORAGE_AUTH_MODE.
        /// </summary>
        public AzureStorageBlobServicePropertiesUpdateTask AuthMode(string authMode = null)
        {
            WithArguments("--auth-mode");
            if (!string.IsNullOrEmpty(authMode))
            {
                 WithArguments(authMode);
            }

            return this;
        }

        /// <summary>
        /// Request timeout in seconds. Applies to each call to the service.
        /// </summary>
        public AzureStorageBlobServicePropertiesUpdateTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }

        /// <summary>
        /// Number of days that soft-deleted blob will be retained. Must be in range [1,365].
        /// </summary>
        public AzureStorageBlobServicePropertiesUpdateTask DaysRetained(string daysRetained = null)
        {
            WithArguments("--days-retained");
            if (!string.IsNullOrEmpty(daysRetained))
            {
                 WithArguments(daysRetained);
            }

            return this;
        }

        /// <summary>
        /// Enables soft-delete.
        /// </summary>
        public AzureStorageBlobServicePropertiesUpdateTask DeleteRetention(string deleteRetention = null)
        {
            WithArguments("--delete-retention");
            if (!string.IsNullOrEmpty(deleteRetention))
            {
                 WithArguments(deleteRetention);
            }

            return this;
        }

        /// <summary>
        /// Represents the path to the error document that should be shown when an error 404 is issued, in other words, when a browser requests a page that does not exist.
        /// </summary>
        public AzureStorageBlobServicePropertiesUpdateTask Document(string Document = null)
        {
            WithArguments("--404-document");
            if (!string.IsNullOrEmpty(Document))
            {
                 WithArguments(Document);
            }

            return this;
        }

        /// <summary>
        /// Represents the name of the index document. This is commonly "index.html".
        /// </summary>
        public AzureStorageBlobServicePropertiesUpdateTask IndexDocument(string indexDocument = null)
        {
            WithArguments("--index-document");
            if (!string.IsNullOrEmpty(indexDocument))
            {
                 WithArguments(indexDocument);
            }

            return this;
        }

        /// <summary>
        /// Enables static-website.
        /// </summary>
        public AzureStorageBlobServicePropertiesUpdateTask StaticWebsite(string staticWebsite = null)
        {
            WithArguments("--static-website");
            if (!string.IsNullOrEmpty(staticWebsite))
            {
                 WithArguments(staticWebsite);
            }

            return this;
        }

        /// <summary>
        /// Storage account key. Must be used in conjunction with storage account name. Environment variable: AZURE_STORAGE_KEY.
        /// </summary>
        public AzureStorageBlobServicePropertiesUpdateTask AccountKey(string accountKey = null)
        {
            WithArguments("--account-key");
            if (!string.IsNullOrEmpty(accountKey))
            {
                 WithArguments(accountKey);
            }

            return this;
        }

        /// <summary>
        /// Storage account name. Related environment variable: AZURE_STORAGE_ACCOUNT. Must be used in conjunction with either storage account key or a SAS token. If neither are present, the command will try to query the storage account key using the authenticated Azure account. If a large number of storage commands are executed the API quota may be hit.
        /// </summary>
        public AzureStorageBlobServicePropertiesUpdateTask AccountName(string accountName = null)
        {
            WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

            return this;
        }

        /// <summary>
        /// Storage account connection string. Environment variable: AZURE_STORAGE_CONNECTION_STRING.
        /// </summary>
        public AzureStorageBlobServicePropertiesUpdateTask ConnectionString(string connectionString = null)
        {
            WithArguments("--connection-string");
            if (!string.IsNullOrEmpty(connectionString))
            {
                 WithArguments(connectionString);
            }

            return this;
        }

        /// <summary>
        /// A Shared Access Signature (SAS). Must be used in conjunction with storage account name. Environment variable: AZURE_STORAGE_SAS_TOKEN.
        /// </summary>
        public AzureStorageBlobServicePropertiesUpdateTask SasToken(string sasToken = null)
        {
            WithArguments("--sas-token");
            if (!string.IsNullOrEmpty(sasToken))
            {
                 WithArguments(sasToken);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureStorageBlobServicePropertiesUpdateTask Add(string add = null)
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
        public AzureStorageBlobServicePropertiesUpdateTask ForceString(string forceString = null)
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
        public AzureStorageBlobServicePropertiesUpdateTask Remove(string remove = null)
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
        public AzureStorageBlobServicePropertiesUpdateTask Set(string set = null)
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
