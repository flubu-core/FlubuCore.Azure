
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkWatcherPacketCaptureCreateTask : ExternalProcessTaskBase<AzureNetworkWatcherPacketCaptureCreateTask>
     {
        
        /// <summary>
        /// Create and start a packet capture session.
        /// </summary>
        public AzureNetworkWatcherPacketCaptureCreateTask(string name = null ,  string resourceGroup = null ,  string vm = null)
        {
            WithArguments("az network watcher packet-capture create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--vm");
            if (!string.IsNullOrEmpty(vm))
            {
                 WithArguments(vm);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The maximum size in bytes of the capture output.
        /// </summary>
        public AzureNetworkWatcherPacketCaptureCreateTask CaptureLimit(string captureLimit = null)
        {
            WithArguments("--capture-limit");
            if (!string.IsNullOrEmpty(captureLimit))
            {
                 WithArguments(captureLimit);
            }

            return this;
        }

        /// <summary>
        /// Number of bytes captured per packet. Excess bytes are truncated.
        /// </summary>
        public AzureNetworkWatcherPacketCaptureCreateTask CaptureSize(string captureSize = null)
        {
            WithArguments("--capture-size");
            if (!string.IsNullOrEmpty(captureSize))
            {
                 WithArguments(captureSize);
            }

            return this;
        }

        /// <summary>
        /// JSON encoded list of packet filters. Use `@{path}` to load from file.
        /// </summary>
        public AzureNetworkWatcherPacketCaptureCreateTask Filters(string filters = null)
        {
            WithArguments("--filters");
            if (!string.IsNullOrEmpty(filters))
            {
                 WithArguments(filters);
            }

            return this;
        }

        /// <summary>
        /// Maximum duration of the capture session in seconds.
        /// </summary>
        public AzureNetworkWatcherPacketCaptureCreateTask TimeLimit(string timeLimit = null)
        {
            WithArguments("--time-limit");
            if (!string.IsNullOrEmpty(timeLimit))
            {
                 WithArguments(timeLimit);
            }

            return this;
        }

        /// <summary>
        /// Local path on the targeted VM at which to save the packet capture. For Linux VMs, the path must start with /var/captures.
        /// </summary>
        public AzureNetworkWatcherPacketCaptureCreateTask FilePath(string filePath = null)
        {
            WithArguments("--file-path");
            if (!string.IsNullOrEmpty(filePath))
            {
                 WithArguments(filePath);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of a storage account to save the packet capture to.
        /// </summary>
        public AzureNetworkWatcherPacketCaptureCreateTask StorageAccount(string storageAccount = null)
        {
            WithArguments("--storage-account");
            if (!string.IsNullOrEmpty(storageAccount))
            {
                 WithArguments(storageAccount);
            }

            return this;
        }

        /// <summary>
        /// Fully qualified URI of an existing storage container in which to store the capture file.
        /// </summary>
        public AzureNetworkWatcherPacketCaptureCreateTask StoragePath(string storagePath = null)
        {
            WithArguments("--storage-path");
            if (!string.IsNullOrEmpty(storagePath))
            {
                 WithArguments(storagePath);
            }

            return this;
        }
     }
}
