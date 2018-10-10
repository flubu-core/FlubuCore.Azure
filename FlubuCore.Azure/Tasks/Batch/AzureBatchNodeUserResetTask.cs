
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchNodeUserResetTask : ExternalProcessTaskBase<AzureBatchNodeUserResetTask>
     {
        
        /// <summary>
        /// Update the properties of a user account on a Batch compute node. Unspecified properties which can be updated are reset to their defaults.
        /// </summary>
        public AzureBatchNodeUserResetTask(string nodeId = null ,  string poolId = null ,  string userName = null)
        {
            WithArguments("az batch node user reset");
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

WithArguments("--user-name");
            if (!string.IsNullOrEmpty(userName))
            {
                 WithArguments(userName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// A file containing the node update user parameter specification in JSON (formatted to match the respective REST API body). If this parameter is specified, all 'Node Update User Arguments' are ignored.
        /// </summary>
        public AzureBatchNodeUserResetTask JsonFile(string jsonFile = null)
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
        public AzureBatchNodeUserResetTask AccountEndpoint(string accountEndpoint = null)
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
        public AzureBatchNodeUserResetTask AccountKey(string accountKey = null)
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
        public AzureBatchNodeUserResetTask AccountName(string accountName = null)
        {
            WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

            return this;
        }

        /// <summary>
        /// The time at which the account should expire. If omitted, the default is 1 day from the current time. For Linux compute nodes, the expiryTime has a precision up to a day. Expected format is an ISO-8601 timestamp.
        /// </summary>
        public AzureBatchNodeUserResetTask ExpiryTime(string expiryTime = null)
        {
            WithArguments("--expiry-time");
            if (!string.IsNullOrEmpty(expiryTime))
            {
                 WithArguments(expiryTime);
            }

            return this;
        }

        /// <summary>
        /// The password of the account. The password is required for Windows nodes (those created with 'cloudServiceConfiguration', or created with 'virtualMachineConfiguration' using a Windows image reference). For Linux compute nodes, the password can optionally be specified along with the sshPublicKey property. If omitted, any existing password is removed.
        /// </summary>
        public AzureBatchNodeUserResetTask Password(string password = null)
        {
            WithArguments("--password");
            if (!string.IsNullOrEmpty(password))
            {
                 WithArguments(password);
            }

            return this;
        }

        /// <summary>
        /// The SSH public key that can be used for remote login to the compute node. The public key should be compatible with OpenSSH encoding and should be base 64 encoded. This property can be specified only for Linux nodes. If this is specified for a Windows node, then the Batch service rejects the request; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). If omitted, any existing SSH public key is removed.
        /// </summary>
        public AzureBatchNodeUserResetTask SshPublicKey(string sshPublicKey = null)
        {
            WithArguments("--ssh-public-key");
            if (!string.IsNullOrEmpty(sshPublicKey))
            {
                 WithArguments(sshPublicKey);
            }

            return this;
        }
     }
}
