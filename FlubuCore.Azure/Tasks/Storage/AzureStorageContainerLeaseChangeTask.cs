
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageContainerLeaseChangeTask : ExternalProcessTaskBase<AzureStorageContainerLeaseChangeTask>
     {
        
        /// <summary>
        /// Change the lease ID of an active lease.
        /// </summary>
        public AzureStorageContainerLeaseChangeTask(string containerName = null ,  string leaseId = null ,  string proposedLeaseId = null)
        {
            WithArguments("az storage container lease change");
WithArguments("--container-name");
            if (!string.IsNullOrEmpty(containerName))
            {
                 WithArguments(containerName);
            }

WithArguments("--lease-id");
            if (!string.IsNullOrEmpty(leaseId))
            {
                 WithArguments(leaseId);
            }

WithArguments("--proposed-lease-id");
            if (!string.IsNullOrEmpty(proposedLeaseId))
            {
                 WithArguments(proposedLeaseId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The mode in which to run the command. "login" mode will directly use your login credentials for the authentication. The legacy "key" mode will attempt to query for an account key if no authentication parameters for the account are provided. Environment variable: AZURE_STORAGE_AUTH_MODE.
        /// </summary>
        public AzureStorageContainerLeaseChangeTask AuthMode(string authMode = null)
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
        public AzureStorageContainerLeaseChangeTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }

        /// <summary>
        /// Commence only if modified since supplied UTC datetime (Y-m-d'T'H:M'Z').
        /// </summary>
        public AzureStorageContainerLeaseChangeTask IfModifiedSince(string ifModifiedSince = null)
        {
            WithArguments("--if-modified-since");
            if (!string.IsNullOrEmpty(ifModifiedSince))
            {
                 WithArguments(ifModifiedSince);
            }

            return this;
        }

        /// <summary>
        /// Commence only if unmodified since supplied UTC datetime (Y-m-d'T'H:M'Z').
        /// </summary>
        public AzureStorageContainerLeaseChangeTask IfUnmodifiedSince(string ifUnmodifiedSince = null)
        {
            WithArguments("--if-unmodified-since");
            if (!string.IsNullOrEmpty(ifUnmodifiedSince))
            {
                 WithArguments(ifUnmodifiedSince);
            }

            return this;
        }

        /// <summary>
        /// Storage account key. Must be used in conjunction with storage account name. Environment variable: AZURE_STORAGE_KEY.
        /// </summary>
        public AzureStorageContainerLeaseChangeTask AccountKey(string accountKey = null)
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
        public AzureStorageContainerLeaseChangeTask AccountName(string accountName = null)
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
        public AzureStorageContainerLeaseChangeTask ConnectionString(string connectionString = null)
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
        public AzureStorageContainerLeaseChangeTask SasToken(string sasToken = null)
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
