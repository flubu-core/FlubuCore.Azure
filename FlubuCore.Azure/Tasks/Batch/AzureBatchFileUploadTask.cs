
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchFileUploadTask : ExternalProcessTaskBase<AzureBatchFileUploadTask>
     {
        
        /// <summary>
        /// Upload a specified file or directory of files to the specified storage path.
        /// </summary>
        public AzureBatchFileUploadTask(string fileGroup = null ,  string localPath = null)
        {
            WithArguments("az batch file upload");
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
        /// If set, will not retain local directory structure in storage.
        /// </summary>
        public AzureBatchFileUploadTask Flatten(string flatten = null)
        {
            WithArguments("--flatten");
            if (!string.IsNullOrEmpty(flatten))
            {
                 WithArguments(flatten);
            }

            return this;
        }

        /// <summary>
        /// Group subdirectory under which files will be uploaded.
        /// </summary>
        public AzureBatchFileUploadTask RemotePath(string remotePath = null)
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
        public AzureBatchFileUploadTask AccountEndpoint(string accountEndpoint = null)
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
        public AzureBatchFileUploadTask AccountKey(string accountKey = null)
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
        public AzureBatchFileUploadTask AccountName(string accountName = null)
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
        public AzureBatchFileUploadTask ResourceGroup(string resourceGroup = null)
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
