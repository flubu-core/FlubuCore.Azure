
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchNodeRebootTask : ExternalProcessTaskBase<AzureBatchNodeRebootTask>
     {
        
        /// <summary>
        /// Restarts the specified compute node.
        /// </summary>
        public AzureBatchNodeRebootTask(string nodeId = null ,  string poolId = null)
        {
            WithArguments("az batch node reboot");
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
        /// When to reboot the compute node and what to do with currently running tasks. The default value is requeue.
        /// </summary>
        public AzureBatchNodeRebootTask NodeRebootOption(string nodeRebootOption = null)
        {
            WithArguments("--node-reboot-option");
            if (!string.IsNullOrEmpty(nodeRebootOption))
            {
                 WithArguments(nodeRebootOption);
            }

            return this;
        }

        /// <summary>
        /// Batch service endpoint. Alternatively, set by environment variable: AZURE_BATCH_ENDPOINT.
        /// </summary>
        public AzureBatchNodeRebootTask AccountEndpoint(string accountEndpoint = null)
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
        public AzureBatchNodeRebootTask AccountKey(string accountKey = null)
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
        public AzureBatchNodeRebootTask AccountName(string accountName = null)
        {
            WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

            return this;
        }
     }
}
