
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageMetricsUpdateTask : ExternalProcessTaskBase<AzureStorageMetricsUpdateTask>
     {
        
        /// <summary>
        /// Update metrics settings for a storage account.
        /// </summary>
        public AzureStorageMetricsUpdateTask(string retention = null ,  string services = null)
        {
            WithArguments("az storage metrics update");
WithArguments("--retention");
            if (!string.IsNullOrEmpty(retention))
            {
                 WithArguments(retention);
            }

WithArguments("--services");
            if (!string.IsNullOrEmpty(services))
            {
                 WithArguments(services);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Specify whether to include API in metrics. Applies to both hour and minute metrics if both are specified. Must be specified if hour or minute metrics are enabled and being updated.
        /// </summary>
        public AzureStorageMetricsUpdateTask Api(string api = null)
        {
            WithArguments("--api");
            if (!string.IsNullOrEmpty(api))
            {
                 WithArguments(api);
            }

            return this;
        }

        /// <summary>
        /// Update the hourly metrics.
        /// </summary>
        public AzureStorageMetricsUpdateTask Hour(string hour = null)
        {
            WithArguments("--hour");
            if (!string.IsNullOrEmpty(hour))
            {
                 WithArguments(hour);
            }

            return this;
        }

        /// <summary>
        /// Update the by-minute metrics.
        /// </summary>
        public AzureStorageMetricsUpdateTask Minute(string minute = null)
        {
            WithArguments("--minute");
            if (!string.IsNullOrEmpty(minute))
            {
                 WithArguments(minute);
            }

            return this;
        }

        /// <summary>
        /// Request timeout in seconds. Applies to each call to the service.
        /// </summary>
        public AzureStorageMetricsUpdateTask Timeout(string timeout = null)
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
        public AzureStorageMetricsUpdateTask AccountKey(string accountKey = null)
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
        public AzureStorageMetricsUpdateTask AccountName(string accountName = null)
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
        public AzureStorageMetricsUpdateTask ConnectionString(string connectionString = null)
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
        public AzureStorageMetricsUpdateTask SasToken(string sasToken = null)
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
