
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageFileDownloadTask : ExternalProcessTaskBase<AzureStorageFileDownloadTask>
     {
        
        /// <summary>
        /// Downloads a file to a file path, with automatic chunking and progress notifications.
        /// </summary>
        public AzureStorageFileDownloadTask(string path = null ,  string shareName = null)
        {
            WithArguments("az storage file download");
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
        /// Path of the file to write to. The source filename will be used if not specified.
        /// </summary>
        public AzureStorageFileDownloadTask Dest(string dest = null)
        {
            WithArguments("--dest");
            if (!string.IsNullOrEmpty(dest))
            {
                 WithArguments(dest);
            }

            return this;
        }

        /// <summary>
        /// End of byte range to use for downloading a section of the file. If end_range is given, start_range must be provided. The start_range and end_range params are inclusive. Ex: start_range=0, end_range=511 will download first 512 bytes of file.
        /// </summary>
        public AzureStorageFileDownloadTask EndRange(string endRange = null)
        {
            WithArguments("--end-range");
            if (!string.IsNullOrEmpty(endRange))
            {
                 WithArguments(endRange);
            }

            return this;
        }

        /// <summary>
        /// If set to 2 or greater, an initial get will be done for the first self.MAX_SINGLE_GET_SIZE bytes of the file. If this is the entire file, the method returns at this point. If it is not, it will download the remaining data parallel using the number of threads equal to max_connections. Each chunk will be of size self.MAX_CHUNK_GET_SIZE. If set to 1, a single large get request will be done. This is not generally recommended but available if very few threads should be used, network requests are very expensive, or a non-seekable stream prevents parallel download. This may also be valuable if the file is being concurrently modified to enforce atomicity or if many files are expected to be empty as an extra request is required for empty files if max_connections is greater than 1.
        /// </summary>
        public AzureStorageFileDownloadTask MaxConnections(string maxConnections = null)
        {
            WithArguments("--max-connections");
            if (!string.IsNullOrEmpty(maxConnections))
            {
                 WithArguments(maxConnections);
            }

            return this;
        }

        /// <summary>
        /// Include this flag to disable progress reporting for the command.
        /// </summary>
        public AzureStorageFileDownloadTask NoProgress(string noProgress = null)
        {
            WithArguments("--no-progress");
            if (!string.IsNullOrEmpty(noProgress))
            {
                 WithArguments(noProgress);
            }

            return this;
        }

        /// <summary>
        /// Mode to use when opening the file. Note that specifying append only open_mode prevents parallel download. So, max_connections must be set to 1 if this open_mode is used.
        /// </summary>
        public AzureStorageFileDownloadTask OpenMode(string openMode = null)
        {
            WithArguments("--open-mode");
            if (!string.IsNullOrEmpty(openMode))
            {
                 WithArguments(openMode);
            }

            return this;
        }

        /// <summary>
        /// A string that represents the snapshot version, if applicable.
        /// </summary>
        public AzureStorageFileDownloadTask Snapshot(string snapshot = null)
        {
            WithArguments("--snapshot");
            if (!string.IsNullOrEmpty(snapshot))
            {
                 WithArguments(snapshot);
            }

            return this;
        }

        /// <summary>
        /// Start of byte range to use for downloading a section of the file. If no end_range is given, all bytes after the start_range will be downloaded. The start_range and end_range params are inclusive. Ex: start_range=0, end_range=511 will download first 512 bytes of file.
        /// </summary>
        public AzureStorageFileDownloadTask StartRange(string startRange = null)
        {
            WithArguments("--start-range");
            if (!string.IsNullOrEmpty(startRange))
            {
                 WithArguments(startRange);
            }

            return this;
        }

        /// <summary>
        /// Request timeout in seconds. Applies to each call to the service.
        /// </summary>
        public AzureStorageFileDownloadTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }

        /// <summary>
        /// If set to true, validates an MD5 hash for each retrieved portion of the file. This is primarily valuable for detecting bitflips on the wire if using http instead of https as https (the default) will already validate. Note that the service will only return transactional MD5s for chunks 4MB or less so the first get request will be of size self.MAX_CHUNK_GET_SIZE instead of self.MAX_SINGLE_GET_SIZE. If self.MAX_CHUNK_GET_SIZE was set to greater than 4MB an error will be thrown. As computing the MD5 takes processing time and more requests will need to be done due to the reduced chunk size there may be some increase in latency.
        /// </summary>
        public AzureStorageFileDownloadTask ValidateContent(string validateContent = null)
        {
            WithArguments("--validate-content");
            if (!string.IsNullOrEmpty(validateContent))
            {
                 WithArguments(validateContent);
            }

            return this;
        }

        /// <summary>
        /// Storage account key. Must be used in conjunction with storage account name. Environment variable: AZURE_STORAGE_KEY.
        /// </summary>
        public AzureStorageFileDownloadTask AccountKey(string accountKey = null)
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
        public AzureStorageFileDownloadTask AccountName(string accountName = null)
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
        public AzureStorageFileDownloadTask ConnectionString(string connectionString = null)
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
        public AzureStorageFileDownloadTask SasToken(string sasToken = null)
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
