
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageTableGenerateSasTask : ExternalProcessTaskBase<AzureStorageTableGenerateSasTask>
     {
        
        /// <summary>
        /// Generates a shared access signature for the table.
        /// </summary>
        public AzureStorageTableGenerateSasTask(string name = null)
        {
            WithArguments("az storage table generate-sas");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The maximum partition key accessible with this shared access signature. endpk must accompany endrk. Key values are inclusive. If omitted, there is no upper bound on the table entities that can be accessed.
        /// </summary>
        public AzureStorageTableGenerateSasTask EndPk(string endPk = null)
        {
            WithArguments("--end-pk");
            if (!string.IsNullOrEmpty(endPk))
            {
                 WithArguments(endPk);
            }

            return this;
        }

        /// <summary>
        /// The maximum row key accessible with this shared access signature. endpk must accompany endrk. Key values are inclusive. If omitted, there is no upper bound on the table entities that can be accessed.
        /// </summary>
        public AzureStorageTableGenerateSasTask EndRk(string endRk = null)
        {
            WithArguments("--end-rk");
            if (!string.IsNullOrEmpty(endRk))
            {
                 WithArguments(endRk);
            }

            return this;
        }

        /// <summary>
        /// Specifies the UTC datetime (Y-m-d'T'H:M'Z') at which the SAS becomes invalid. Do not use if a stored access policy is referenced with --id that specifies this value.
        /// </summary>
        public AzureStorageTableGenerateSasTask Expiry(string expiry = null)
        {
            WithArguments("--expiry");
            if (!string.IsNullOrEmpty(expiry))
            {
                 WithArguments(expiry);
            }

            return this;
        }

        /// <summary>
        /// Only permit requests made with the HTTPS protocol. If omitted, requests from both the HTTP and HTTPS protocol are permitted.
        /// </summary>
        public AzureStorageTableGenerateSasTask HttpsOnly(string httpsOnly = null)
        {
            WithArguments("--https-only");
            if (!string.IsNullOrEmpty(httpsOnly))
            {
                 WithArguments(httpsOnly);
            }

            return this;
        }

        /// <summary>
        /// Specifies the IP address or range of IP addresses from which to accept requests. Supports only IPv4 style addresses.
        /// </summary>
        public AzureStorageTableGenerateSasTask Ip(string ip = null)
        {
            WithArguments("--ip");
            if (!string.IsNullOrEmpty(ip))
            {
                 WithArguments(ip);
            }

            return this;
        }

        /// <summary>
        /// The permissions the SAS grants. Allowed values: (r)ead/query (a)dd (u)pdate (d)elete. Do not use if a stored access policy is referenced with --id that specifies this value. Can be combined.
        /// </summary>
        public AzureStorageTableGenerateSasTask Permissions(string permissions = null)
        {
            WithArguments("--permissions");
            if (!string.IsNullOrEmpty(permissions))
            {
                 WithArguments(permissions);
            }

            return this;
        }

        /// <summary>
        /// The name of a stored access policy within the table's ACL.
        /// </summary>
        public AzureStorageTableGenerateSasTask PolicyName(string policyName = null)
        {
            WithArguments("--policy-name");
            if (!string.IsNullOrEmpty(policyName))
            {
                 WithArguments(policyName);
            }

            return this;
        }

        /// <summary>
        /// Specifies the UTC datetime (Y-m-d'T'H:M'Z') at which the SAS becomes valid. Do not use if a stored access policy is referenced with --id that specifies this value. Defaults to the time of the request.
        /// </summary>
        public AzureStorageTableGenerateSasTask Start(string start = null)
        {
            WithArguments("--start");
            if (!string.IsNullOrEmpty(start))
            {
                 WithArguments(start);
            }

            return this;
        }

        /// <summary>
        /// The minimum partition key accessible with this shared access signature. startpk must accompany startrk. Key values are inclusive. If omitted, there is no lower bound on the table entities that can be accessed.
        /// </summary>
        public AzureStorageTableGenerateSasTask StartPk(string startPk = null)
        {
            WithArguments("--start-pk");
            if (!string.IsNullOrEmpty(startPk))
            {
                 WithArguments(startPk);
            }

            return this;
        }

        /// <summary>
        /// The minimum row key accessible with this shared access signature. startpk must accompany startrk. Key values are inclusive. If omitted, there is no lower bound on the table entities that can be accessed.
        /// </summary>
        public AzureStorageTableGenerateSasTask StartRk(string startRk = null)
        {
            WithArguments("--start-rk");
            if (!string.IsNullOrEmpty(startRk))
            {
                 WithArguments(startRk);
            }

            return this;
        }

        /// <summary>
        /// Storage account key. Must be used in conjunction with storage account name. Environment variable: AZURE_STORAGE_KEY.
        /// </summary>
        public AzureStorageTableGenerateSasTask AccountKey(string accountKey = null)
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
        public AzureStorageTableGenerateSasTask AccountName(string accountName = null)
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
        public AzureStorageTableGenerateSasTask ConnectionString(string connectionString = null)
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
        public AzureStorageTableGenerateSasTask SasToken(string sasToken = null)
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
