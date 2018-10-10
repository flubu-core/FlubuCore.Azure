
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageEntityQueryTask : ExternalProcessTaskBase<AzureStorageEntityQueryTask>
     {
        
        /// <summary>
        /// List entities which satisfy a query.
        /// </summary>
        public AzureStorageEntityQueryTask(string tableName = null)
        {
            WithArguments("az storage entity query");
WithArguments("--table-name");
            if (!string.IsNullOrEmpty(tableName))
            {
                 WithArguments(tableName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Specifies how much metadata to include in the response payload.
        /// </summary>
        public AzureStorageEntityQueryTask Accept(string accept = null)
        {
            WithArguments("--accept");
            if (!string.IsNullOrEmpty(accept))
            {
                 WithArguments(accept);
            }

            return this;
        }

        /// <summary>
        /// Returns only entities that satisfy the specified filter. Note that no more than 15 discrete comparisons are permitted within a $filter string. See <a href="http://msdn.microsoft.com/en-us/library/windowsazure/dd894031.aspx">http://msdn.microsoft.com/en-us/library/windowsazure/dd894031.aspx</a> for more information on constructing filters.
        /// </summary>
        public AzureStorageEntityQueryTask Filter(string filter = null)
        {
            WithArguments("--filter");
            if (!string.IsNullOrEmpty(filter))
            {
                 WithArguments(filter);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of key=value pairs. Must contain a nextpartitionkey and a nextrowkey.
        /// </summary>
        public AzureStorageEntityQueryTask Marker(string marker = null)
        {
            WithArguments("--marker");
            if (!string.IsNullOrEmpty(marker))
            {
                 WithArguments(marker);
            }

            return this;
        }

        /// <summary>
        /// The maximum number of entities to return.
        /// </summary>
        public AzureStorageEntityQueryTask NumResults(string numResults = null)
        {
            WithArguments("--num-results");
            if (!string.IsNullOrEmpty(numResults))
            {
                 WithArguments(numResults);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of properties to return for each entity.
        /// </summary>
        public AzureStorageEntityQueryTask Select(string select = null)
        {
            WithArguments("--select");
            if (!string.IsNullOrEmpty(select))
            {
                 WithArguments(select);
            }

            return this;
        }

        /// <summary>
        /// Request timeout in seconds. Applies to each call to the service.
        /// </summary>
        public AzureStorageEntityQueryTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }

        /// <summary>
        /// Storage account key. Must be used in conjunction with storage account name. Environment variable: AZURE_STORAGE_KEY.
        /// </summary>
        public AzureStorageEntityQueryTask AccountKey(string accountKey = null)
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
        public AzureStorageEntityQueryTask AccountName(string accountName = null)
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
        public AzureStorageEntityQueryTask ConnectionString(string connectionString = null)
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
        public AzureStorageEntityQueryTask SasToken(string sasToken = null)
        {
            WithArguments("--sas-token");
            if (!string.IsNullOrEmpty(sasToken))
            {
                 WithArguments(sasToken);
            }

            return this;
        }
     }
}
