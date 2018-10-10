
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageShareDeleteTask : ExternalProcessTaskBase<AzureStorageShareDeleteTask>
     {
        
        /// <summary>
        /// Marks the specified share for deletion.
        /// </summary>
        public AzureStorageShareDeleteTask(string name = null)
        {
            WithArguments("az storage share delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Specify the deletion strategy when the share has snapshots.
        /// </summary>
        public AzureStorageShareDeleteTask DeleteSnapshots(string deleteSnapshots = null)
        {
            WithArguments("--delete-snapshots");
            if (!string.IsNullOrEmpty(deleteSnapshots))
            {
                 WithArguments(deleteSnapshots);
            }

            return this;
        }

        /// <summary>
        /// Specify whether to throw an exception when the share doesn't exist. False by default.
        /// </summary>
        public AzureStorageShareDeleteTask FailNotExist(string failNotExist = null)
        {
            WithArguments("--fail-not-exist");
            if (!string.IsNullOrEmpty(failNotExist))
            {
                 WithArguments(failNotExist);
            }

            return this;
        }

        /// <summary>
        /// A string that represents the snapshot version, if applicable. Specify this argument to delete a specific snapshot only. delete_snapshots must be None if this is specified.
        /// </summary>
        public AzureStorageShareDeleteTask Snapshot(string snapshot = null)
        {
            WithArguments("--snapshot");
            if (!string.IsNullOrEmpty(snapshot))
            {
                 WithArguments(snapshot);
            }

            return this;
        }

        /// <summary>
        /// Request timeout in seconds. Applies to each call to the service.
        /// </summary>
        public AzureStorageShareDeleteTask Timeout(string timeout = null)
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
        public AzureStorageShareDeleteTask AccountKey(string accountKey = null)
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
        public AzureStorageShareDeleteTask AccountName(string accountName = null)
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
        public AzureStorageShareDeleteTask ConnectionString(string connectionString = null)
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
        public AzureStorageShareDeleteTask SasToken(string sasToken = null)
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
