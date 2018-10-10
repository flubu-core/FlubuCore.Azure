
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchCertificateDeleteTask : ExternalProcessTaskBase<AzureBatchCertificateDeleteTask>
     {
        
        /// <summary>
        /// Delete a certificate from a Batch account.
        /// </summary>
        public AzureBatchCertificateDeleteTask(string thumbprint = null)
        {
            WithArguments("az batch certificate delete");
WithArguments("--thumbprint");
            if (!string.IsNullOrEmpty(thumbprint))
            {
                 WithArguments(thumbprint);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Cancel the failed certificate deletion operation.
        /// </summary>
        public AzureBatchCertificateDeleteTask Abort(string abort = null)
        {
            WithArguments("--abort");
            if (!string.IsNullOrEmpty(abort))
            {
                 WithArguments(abort);
            }

            return this;
        }

        /// <summary>
        /// Do not prompt for confirmation.
        /// </summary>
        public AzureBatchCertificateDeleteTask Yes(string yes = null)
        {
            WithArguments("--yes");
            if (!string.IsNullOrEmpty(yes))
            {
                 WithArguments(yes);
            }

            return this;
        }

        /// <summary>
        /// Batch service endpoint. Alternatively, set by environment variable: AZURE_BATCH_ENDPOINT.
        /// </summary>
        public AzureBatchCertificateDeleteTask AccountEndpoint(string accountEndpoint = null)
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
        public AzureBatchCertificateDeleteTask AccountKey(string accountKey = null)
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
        public AzureBatchCertificateDeleteTask AccountName(string accountName = null)
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
