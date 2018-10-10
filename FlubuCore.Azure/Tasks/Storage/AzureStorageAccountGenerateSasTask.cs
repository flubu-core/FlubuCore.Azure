
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageAccountGenerateSasTask : ExternalProcessTaskBase<AzureStorageAccountGenerateSasTask>
     {
        
        /// <summary>
        /// Generates a shared access signature for the account.
        /// </summary>
        public AzureStorageAccountGenerateSasTask(string expiry = null ,  string permissions = null ,  string resourceTypes = null ,  string services = null)
        {
            WithArguments("az storage account generate-sas");
WithArguments("--expiry");
            if (!string.IsNullOrEmpty(expiry))
            {
                 WithArguments(expiry);
            }

WithArguments("--permissions");
            if (!string.IsNullOrEmpty(permissions))
            {
                 WithArguments(permissions);
            }

WithArguments("--resource-types");
            if (!string.IsNullOrEmpty(resourceTypes))
            {
                 WithArguments(resourceTypes);
            }

WithArguments("--services");
            if (!string.IsNullOrEmpty(services))
            {
                 WithArguments(services);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Only permit requests made with the HTTPS protocol. If omitted, requests from both the HTTP and HTTPS protocol are permitted.
        /// </summary>
        public AzureStorageAccountGenerateSasTask HttpsOnly(string httpsOnly = null)
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
        public AzureStorageAccountGenerateSasTask Ip(string ip = null)
        {
            WithArguments("--ip");
            if (!string.IsNullOrEmpty(ip))
            {
                 WithArguments(ip);
            }

            return this;
        }

        /// <summary>
        /// Specifies the UTC datetime (Y-m-d'T'H:M'Z') at which the SAS becomes valid. Defaults to the time of the request.
        /// </summary>
        public AzureStorageAccountGenerateSasTask Start(string start = null)
        {
            WithArguments("--start");
            if (!string.IsNullOrEmpty(start))
            {
                 WithArguments(start);
            }

            return this;
        }

        /// <summary>
        /// Storage account key. Must be used in conjunction with storage account name. Environment variable: AZURE_STORAGE_KEY.
        /// </summary>
        public AzureStorageAccountGenerateSasTask AccountKey(string accountKey = null)
        {
            WithArguments("--account-key");
            if (!string.IsNullOrEmpty(accountKey))
            {
                 WithArguments(accountKey);
            }

            return this;
        }

        /// <summary>
        /// Storage account name. Must be used in conjunction with either storage account key or a SAS token. Environment Variable: AZURE_STORAGE_ACCOUNT.
        /// </summary>
        public AzureStorageAccountGenerateSasTask AccountName(string accountName = null)
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
        public AzureStorageAccountGenerateSasTask ConnectionString(string connectionString = null)
        {
            WithArguments("--connection-string");
            if (!string.IsNullOrEmpty(connectionString))
            {
                 WithArguments(connectionString);
            }

            return this;
        }
     }
}
