
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchFileDownloadTask : ExternalProcessTaskBase<AzureBatchFileDownloadTask>
     {
        
        /// <summary>
        /// Download a specified file or directory of files to the specified storage path.
        /// </summary>
        public AzureBatchFileDownloadTask(string fileGroup = null ,  string localPath = null)
        {
            WithArguments("az batch file download");
WithArguments("--file-group");
            if (!string.IsNullOrEmpty(fileGroup))
            {
                 WithArguments(fileGroup);
            }

WithArguments("--local-path");
            if (!string.IsNullOrEmpty(localPath))
            {
                 WithArguments(localPath);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// If set, an existing file in the local path will be overwritten.
        /// </summary>
        public AzureBatchFileDownloadTask Overwrite(string overwrite = null)
        {
            WithArguments("--overwrite");
            if (!string.IsNullOrEmpty(overwrite))
            {
                 WithArguments(overwrite);
            }

            return this;
        }

        /// <summary>
        /// The subdirectory under which files exist remotely.
        /// </summary>
        public AzureBatchFileDownloadTask RemotePath(string remotePath = null)
        {
            WithArguments("--remote-path");
            if (!string.IsNullOrEmpty(remotePath))
            {
                 WithArguments(remotePath);
            }

            return this;
        }

        /// <summary>
        /// Batch service endpoint. Alternatively, set by environment variable: AZURE_BATCH_ENDPOINT.
        /// </summary>
        public AzureBatchFileDownloadTask AccountEndpoint(string accountEndpoint = null)
        {
            WithArguments("--account-endpoint");
            if (!string.IsNullOrEmpty(accountEndpoint))
            {
                 WithArguments(accountEndpoint);
            }

            return this;
        }

        /// <summary>
        /// The Batch account key. Alternatively, set by environment variable: AZURE_BATCH_ACCESS_KEY.
        /// </summary>
        public AzureBatchFileDownloadTask AccountKey(string accountKey = null)
        {
            WithArguments("--account-key");
            if (!string.IsNullOrEmpty(accountKey))
            {
                 WithArguments(accountKey);
            }

            return this;
        }

        /// <summary>
        /// The Batch account name. Alternatively, set by environment variable: AZURE_BATCH_ACCOUNT.
        /// </summary>
        public AzureBatchFileDownloadTask AccountName(string accountName = null)
        {
            WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

            return this;
        }

        /// <summary>
        /// The resource group of the Batch account.
        /// </summary>
        public AzureBatchFileDownloadTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }
     }
}
