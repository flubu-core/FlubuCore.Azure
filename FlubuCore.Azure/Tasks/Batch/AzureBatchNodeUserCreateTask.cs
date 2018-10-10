
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchNodeUserCreateTask : ExternalProcessTaskBase<AzureBatchNodeUserCreateTask>
     {
        
        /// <summary>
        /// Add a user account to a Batch compute node.
        /// </summary>
        public AzureBatchNodeUserCreateTask(string nodeId = null ,  string poolId = null)
        {
            WithArguments("az batch node user create");
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
        /// A file containing the user specification in JSON (formatted to match the respective REST API body). If this parameter is specified, all 'User Arguments' are ignored.
        /// </summary>
        public AzureBatchNodeUserCreateTask JsonFile(string jsonFile = null)
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
        public AzureBatchNodeUserCreateTask AccountEndpoint(string accountEndpoint = null)
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
        public AzureBatchNodeUserCreateTask AccountKey(string accountKey = null)
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
        public AzureBatchNodeUserCreateTask AccountName(string accountName = null)
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
        public AzureBatchNodeUserCreateTask ExpiryTime(string expiryTime = null)
        {
            WithArguments("--expiry-time");
            if (!string.IsNullOrEmpty(expiryTime))
            {
                 WithArguments(expiryTime);
            }

            return this;
        }

        /// <summary>
        /// Whether the account should be an administrator on the compute node. The default value is false. True if flag present.
        /// </summary>
        public AzureBatchNodeUserCreateTask IsAdmin(string isAdmin = null)
        {
            WithArguments("--is-admin");
            if (!string.IsNullOrEmpty(isAdmin))
            {
                 WithArguments(isAdmin);
            }

            return this;
        }

        /// <summary>
        /// Required. The user name of the account.
        /// </summary>
        public AzureBatchNodeUserCreateTask Name(string name = null)
        {
            WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

            return this;
        }

        /// <summary>
        /// The password of the account. The password is required for Windows nodes (those created with 'cloudServiceConfiguration', or created with 'virtualMachineConfiguration' using a Windows image reference). For Linux compute nodes, the password can optionally be specified along with the sshPublicKey property.
        /// </summary>
        public AzureBatchNodeUserCreateTask Password(string password = null)
        {
            WithArguments("--password");
            if (!string.IsNullOrEmpty(password))
            {
                 WithArguments(password);
            }

            return this;
        }

        /// <summary>
        /// The SSH public key that can be used for remote login to the compute node. The public key should be compatible with OpenSSH encoding and should be base 64 encoded. This property can be specified only for Linux nodes. If this is specified for a Windows node, then the Batch service rejects the request; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request).
        /// </summary>
        public AzureBatchNodeUserCreateTask SshPublicKey(string sshPublicKey = null)
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
