
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dls
{
     public partial class AzureDlsFsDownloadTask : ExternalProcessTaskBase<AzureDlsFsDownloadTask>
     {
        
        /// <summary>
        /// Download a file or folder from a Data Lake Store account to the local machine.
        /// </summary>
        public AzureDlsFsDownloadTask(string account = null ,  string destinationPath = null ,  string sourcePath = null)
        {
            WithArguments("az dls fs download");
WithArguments("--account");
            if (!string.IsNullOrEmpty(account))
            {
                 WithArguments(account);
            }

WithArguments("--destination-path");
            if (!string.IsNullOrEmpty(destinationPath))
            {
                 WithArguments(destinationPath);
            }

WithArguments("--source-path");
            if (!string.IsNullOrEmpty(sourcePath))
            {
                 WithArguments(sourcePath);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Size of a block, in bytes.
        /// </summary>
        public AzureDlsFsDownloadTask BlockSize(string blockSize = null)
        {
            WithArguments("--block-size");
            if (!string.IsNullOrEmpty(blockSize))
            {
                 WithArguments(blockSize);
            }

            return this;
        }

        /// <summary>
        /// Size of the transfer buffer, in bytes.
        /// </summary>
        public AzureDlsFsDownloadTask BufferSize(string bufferSize = null)
        {
            WithArguments("--buffer-size");
            if (!string.IsNullOrEmpty(bufferSize))
            {
                 WithArguments(bufferSize);
            }

            return this;
        }

        /// <summary>
        /// Size of a chunk, in bytes.
        /// </summary>
        public AzureDlsFsDownloadTask ChunkSize(string chunkSize = null)
        {
            WithArguments("--chunk-size");
            if (!string.IsNullOrEmpty(chunkSize))
            {
                 WithArguments(chunkSize);
            }

            return this;
        }

        /// <summary>
        /// Indicates that, if the destination file or folder exists, it should be overwritten.
        /// </summary>
        public AzureDlsFsDownloadTask Overwrite(string overwrite = null)
        {
            WithArguments("--overwrite");
            if (!string.IsNullOrEmpty(overwrite))
            {
                 WithArguments(overwrite);
            }

            return this;
        }

        public AzureDlsFsDownloadTask ProgressCallback(string progressCallback = null)
        {
            WithArguments("--progress-callback");
            if (!string.IsNullOrEmpty(progressCallback))
            {
                 WithArguments(progressCallback);
            }

            return this;
        }

        /// <summary>
        /// Parallelism of the download. Default: The number of cores in the local machine.
        /// </summary>
        public AzureDlsFsDownloadTask ThreadCount(string threadCount = null)
        {
            WithArguments("--thread-count");
            if (!string.IsNullOrEmpty(threadCount))
            {
                 WithArguments(threadCount);
            }

            return this;
        }
     }
}
