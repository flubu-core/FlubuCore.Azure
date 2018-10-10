
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchNodeServiceLogsUploadTask : ExternalProcessTaskBase<AzureBatchNodeServiceLogsUploadTask>
     {
        
        /// <summary>
        /// Upload Azure Batch service log files from the specified compute node to Azure Blob Storage.
        /// </summary>
        public AzureBatchNodeServiceLogsUploadTask(string nodeId = null ,  string poolId = null)
        {
            WithArguments("az batch node service-logs upload");
WithArguments("--node-id");
            if (!string.IsNullOrEmpty(nodeId))
            {
                 WithArguments(nodeId);
            }

WithArguments("--pool-id");
            if (!string.IsNullOrEmpty(poolId))
            {
                 WithArguments(poolId);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// A file containing the upload batch service logs configuration specification in JSON (formatted to match the respective REST API body). If this parameter is specified, all 'Upload Batch Service Logs Configuration Arguments' are ignored.
        /// </summary>
        public AzureBatchNodeServiceLogsUploadTask JsonFile(string jsonFile = null)
        {
            WithArguments("--json-file");
            if (!string.IsNullOrEmpty(jsonFile))
            {
                 WithArguments(jsonFile);
            }

            return this;
        }

        /// <summary>
        /// Batch service endpoint. Alternatively, set by environment variable: AZURE_BATCH_ENDPOINT.
        /// </summary>
        public AzureBatchNodeServiceLogsUploadTask AccountEndpoint(string accountEndpoint = null)
        {
            WithArguments("--account-endpoint");
            if (!string.IsNullOrEmpty(accountEndpoint))
            {
                 WithArguments(accountEndpoint);
            }

            return this;
        }

        /// <summary>
        /// Batch account key. Alternatively, set by environment variable: AZURE_BATCH_ACCESS_KEY.
        /// </summary>
        public AzureBatchNodeServiceLogsUploadTask AccountKey(string accountKey = null)
        {
            WithArguments("--account-key");
            if (!string.IsNullOrEmpty(accountKey))
            {
                 WithArguments(accountKey);
            }

            return this;
        }

        /// <summary>
        /// Batch account name. Alternatively, set by environment variable: AZURE_BATCH_ACCOUNT.
        /// </summary>
        public AzureBatchNodeServiceLogsUploadTask AccountName(string accountName = null)
        {
            WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

            return this;
        }

        /// <summary>
        /// Required. The URL of the container within Azure Blob Storage to which to upload the Batch Service log file(s). The URL must include a Shared Access Signature (SAS) granting write permissions to the container. The SAS duration must allow enough time for the upload to finish. The start time for SAS is optional and recommended to not be specified.
        /// </summary>
        public AzureBatchNodeServiceLogsUploadTask ContainerUrl(string containerUrl = null)
        {
            WithArguments("--container-url");
            if (!string.IsNullOrEmpty(containerUrl))
            {
                 WithArguments(containerUrl);
            }

            return this;
        }

        /// <summary>
        /// The end of the time range from which to upload Batch Service log file(s). Any log file containing a log message in the time range will be uploaded. This means that the operation might retrieve more logs than have been requested since the entire log file is always uploaded, but the operation should not retrieve fewer logs than have been requested. If omitted, the default is to upload all logs available after the startTime. Expected format is an ISO-8601 timestamp.
        /// </summary>
        public AzureBatchNodeServiceLogsUploadTask EndTime(string endTime = null)
        {
            WithArguments("--end-time");
            if (!string.IsNullOrEmpty(endTime))
            {
                 WithArguments(endTime);
            }

            return this;
        }

        /// <summary>
        /// Required. The start of the time range from which to upload Batch Service log file(s). Any log file containing a log message in the time range will be uploaded. This means that the operation might retrieve more logs than have been requested since the entire log file is always uploaded, but the operation should not retrieve fewer logs than have been requested. Expected format is an ISO-8601 timestamp.
        /// </summary>
        public AzureBatchNodeServiceLogsUploadTask StartTime(string startTime = null)
        {
            WithArguments("--start-time");
            if (!string.IsNullOrEmpty(startTime))
            {
                 WithArguments(startTime);
            }

            return this;
        }
     }
}
