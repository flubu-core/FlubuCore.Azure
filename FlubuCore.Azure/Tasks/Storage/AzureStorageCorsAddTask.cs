
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageCorsAddTask : ExternalProcessTaskBase<AzureStorageCorsAddTask>
     {
        
        /// <summary>
        /// Add a CORS rule to a storage account.
        /// </summary>
        public AzureStorageCorsAddTask(string methods = null ,  string origins = null ,  string services = null)
        {
            WithArguments("az storage cors add");
WithArguments("--methods");
            if (!string.IsNullOrEmpty(methods))
            {
                 WithArguments(methods);
            }

WithArguments("--origins");
            if (!string.IsNullOrEmpty(origins))
            {
                 WithArguments(origins);
            }

WithArguments("--services");
            if (!string.IsNullOrEmpty(services))
            {
                 WithArguments(services);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Space-separated list of response headers allowed to be part of the cross-origin request.
        /// </summary>
        public AzureStorageCorsAddTask AllowedHeaders(string allowedHeaders = null)
        {
            WithArguments("--allowed-headers");
            if (!string.IsNullOrEmpty(allowedHeaders))
            {
                 WithArguments(allowedHeaders);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of response headers to expose to CORS clients.
        /// </summary>
        public AzureStorageCorsAddTask ExposedHeaders(string exposedHeaders = null)
        {
            WithArguments("--exposed-headers");
            if (!string.IsNullOrEmpty(exposedHeaders))
            {
                 WithArguments(exposedHeaders);
            }

            return this;
        }

        /// <summary>
        /// The maximum number of seconds the client/browser should cache a preflight response.
        /// </summary>
        public AzureStorageCorsAddTask MaxAge(string maxAge = null)
        {
            WithArguments("--max-age");
            if (!string.IsNullOrEmpty(maxAge))
            {
                 WithArguments(maxAge);
            }

            return this;
        }

        /// <summary>
        /// Request timeout in seconds. Applies to each call to the service.
        /// </summary>
        public AzureStorageCorsAddTask Timeout(string timeout = null)
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
        public AzureStorageCorsAddTask AccountKey(string accountKey = null)
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
        public AzureStorageCorsAddTask AccountName(string accountName = null)
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
        public AzureStorageCorsAddTask ConnectionString(string connectionString = null)
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
        public AzureStorageCorsAddTask SasToken(string sasToken = null)
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
