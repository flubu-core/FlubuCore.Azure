
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchCertificateCreateTask : ExternalProcessTaskBase<AzureBatchCertificateCreateTask>
     {
        
        /// <summary>
        /// Add a certificate to a Batch account.
        /// </summary>
        public AzureBatchCertificateCreateTask(string certificateFile = null ,  string thumbprint = null)
        {
            WithArguments("az batch certificate create");
WithArguments("--certificate-file");
            if (!string.IsNullOrEmpty(certificateFile))
            {
                 WithArguments(certificateFile);
            }

WithArguments("--thumbprint");
            if (!string.IsNullOrEmpty(thumbprint))
            {
                 WithArguments(thumbprint);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The password to access the certificate's private key.
        /// </summary>
        public AzureBatchCertificateCreateTask Password(string password = null)
        {
            WithArguments("--password");
            if (!string.IsNullOrEmpty(password))
            {
                 WithArguments(password);
            }

            return this;
        }

        /// <summary>
        /// Batch service endpoint. Alternatively, set by environment variable: AZURE_BATCH_ENDPOINT.
        /// </summary>
        public AzureBatchCertificateCreateTask AccountEndpoint(string accountEndpoint = null)
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
        public AzureBatchCertificateCreateTask AccountKey(string accountKey = null)
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
        public AzureBatchCertificateCreateTask AccountName(string accountName = null)
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
