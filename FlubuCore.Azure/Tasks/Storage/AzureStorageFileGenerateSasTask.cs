
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageFileGenerateSasTask : ExternalProcessTaskBase<AzureStorageFileGenerateSasTask>
     {
        
        /// <summary>
        /// Generates a shared access signature for the file.
        /// </summary>
        public AzureStorageFileGenerateSasTask(string path = null ,  string shareName = null)
        {
            WithArguments("az storage file generate-sas");
WithArguments("--path");
            if (!string.IsNullOrEmpty(path))
            {
                 WithArguments(path);
            }

WithArguments("--share-name");
            if (!string.IsNullOrEmpty(shareName))
            {
                 WithArguments(shareName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Response header value for Cache-Control when resource is accessed using this shared access signature.
        /// </summary>
        public AzureStorageFileGenerateSasTask CacheControl(string cacheControl = null)
        {
            WithArguments("--cache-control");
            if (!string.IsNullOrEmpty(cacheControl))
            {
                 WithArguments(cacheControl);
            }

            return this;
        }

        /// <summary>
        /// Response header value for Content-Disposition when resource is accessed using this shared access signature.
        /// </summary>
        public AzureStorageFileGenerateSasTask ContentDisposition(string contentDisposition = null)
        {
            WithArguments("--content-disposition");
            if (!string.IsNullOrEmpty(contentDisposition))
            {
                 WithArguments(contentDisposition);
            }

            return this;
        }

        /// <summary>
        /// Response header value for Content-Encoding when resource is accessed using this shared access signature.
        /// </summary>
        public AzureStorageFileGenerateSasTask ContentEncoding(string contentEncoding = null)
        {
            WithArguments("--content-encoding");
            if (!string.IsNullOrEmpty(contentEncoding))
            {
                 WithArguments(contentEncoding);
            }

            return this;
        }

        /// <summary>
        /// Response header value for Content-Language when resource is accessed using this shared access signature.
        /// </summary>
        public AzureStorageFileGenerateSasTask ContentLanguage(string contentLanguage = null)
        {
            WithArguments("--content-language");
            if (!string.IsNullOrEmpty(contentLanguage))
            {
                 WithArguments(contentLanguage);
            }

            return this;
        }

        /// <summary>
        /// Response header value for Content-Type when resource is accessed using this shared access signature.
        /// </summary>
        public AzureStorageFileGenerateSasTask ContentType(string contentType = null)
        {
            WithArguments("--content-type");
            if (!string.IsNullOrEmpty(contentType))
            {
                 WithArguments(contentType);
            }

            return this;
        }

        /// <summary>
        /// Specifies the UTC datetime (Y-m-d'T'H:M'Z') at which the SAS becomes invalid. Do not use if a stored access policy is referenced with --id that specifies this value.
        /// </summary>
        public AzureStorageFileGenerateSasTask Expiry(string expiry = null)
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
        public AzureStorageFileGenerateSasTask HttpsOnly(string httpsOnly = null)
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
        public AzureStorageFileGenerateSasTask Ip(string ip = null)
        {
            WithArguments("--ip");
            if (!string.IsNullOrEmpty(ip))
            {
                 WithArguments(ip);
            }

            return this;
        }

        /// <summary>
        /// The permissions the SAS grants. Allowed values: (c)reate (d)elete (r)ead (w)rite. Do not use if a stored access policy is referenced with --id that specifies this value. Can be combined.
        /// </summary>
        public AzureStorageFileGenerateSasTask Permissions(string permissions = null)
        {
            WithArguments("--permissions");
            if (!string.IsNullOrEmpty(permissions))
            {
                 WithArguments(permissions);
            }

            return this;
        }

        /// <summary>
        /// The name of a stored access policy within the container's ACL.
        /// </summary>
        public AzureStorageFileGenerateSasTask PolicyName(string policyName = null)
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
        public AzureStorageFileGenerateSasTask Start(string start = null)
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
        public AzureStorageFileGenerateSasTask AccountKey(string accountKey = null)
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
        public AzureStorageFileGenerateSasTask AccountName(string accountName = null)
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
        public AzureStorageFileGenerateSasTask ConnectionString(string connectionString = null)
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
        public AzureStorageFileGenerateSasTask SasToken(string sasToken = null)
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
