
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventhubs
{
     public partial class AzureEventhubsEventhubCreateTask : ExternalProcessTaskBase<AzureEventhubsEventhubCreateTask>
     {
        
        /// <summary>
        /// Creates the Event Hubs Eventhub.
        /// </summary>
        public AzureEventhubsEventhubCreateTask(string name = null ,  string namespaceName = null ,  string resourceGroup = null)
        {
            WithArguments("az eventhubs eventhub create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--namespace-name");
            if (!string.IsNullOrEmpty(namespaceName))
            {
                 WithArguments(namespaceName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// A boolean value that indicates whether capture description is enabled.
        /// </summary>
        public AzureEventhubsEventhubCreateTask EnableCapture(string enableCapture = null)
        {
            WithArguments("--enable-capture");
            if (!string.IsNullOrEmpty(enableCapture))
            {
                 WithArguments(enableCapture);
            }

            return this;
        }

        /// <summary>
        /// Number of days to retain events for this Event Hub, value should be 1 to 7 days.
        /// </summary>
        public AzureEventhubsEventhubCreateTask MessageRetention(string messageRetention = null)
        {
            WithArguments("--message-retention");
            if (!string.IsNullOrEmpty(messageRetention))
            {
                 WithArguments(messageRetention);
            }

            return this;
        }

        /// <summary>
        /// Number of partitions created for the Event Hub. By default, allowed values are 2-32. Lower value of 1 is supported with Kafka enabled namespaces. In presence of a custom quota, the upper limit will match the upper limit of the quota.
        /// </summary>
        public AzureEventhubsEventhubCreateTask PartitionCount(string partitionCount = null)
        {
            WithArguments("--partition-count");
            if (!string.IsNullOrEmpty(partitionCount))
            {
                 WithArguments(partitionCount);
            }

            return this;
        }

        /// <summary>
        /// Status of Eventhub.
        /// </summary>
        public AzureEventhubsEventhubCreateTask Status(string status = null)
        {
            WithArguments("--status");
            if (!string.IsNullOrEmpty(status))
            {
                 WithArguments(status);
            }

            return this;
        }

        /// <summary>
        /// Allows you to set the frequency with which the capture to Azure Blobs will happen, value should between 60 to 900 seconds.
        /// </summary>
        public AzureEventhubsEventhubCreateTask CaptureInterval(string captureInterval = null)
        {
            WithArguments("--capture-interval");
            if (!string.IsNullOrEmpty(captureInterval))
            {
                 WithArguments(captureInterval);
            }

            return this;
        }

        /// <summary>
        /// Defines the amount of data built up in your Event Hub before an capture operation, value should be between 10485760 to 524288000 bytes.
        /// </summary>
        public AzureEventhubsEventhubCreateTask CaptureSizeLimit(string captureSizeLimit = null)
        {
            WithArguments("--capture-size-limit");
            if (!string.IsNullOrEmpty(captureSizeLimit))
            {
                 WithArguments(captureSizeLimit);
            }

            return this;
        }

        /// <summary>
        /// Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order.
        /// </summary>
        public AzureEventhubsEventhubCreateTask ArchiveNameFormat(string archiveNameFormat = null)
        {
            WithArguments("--archive-name-format");
            if (!string.IsNullOrEmpty(archiveNameFormat))
            {
                 WithArguments(archiveNameFormat);
            }

            return this;
        }

        /// <summary>
        /// Blob container Name.
        /// </summary>
        public AzureEventhubsEventhubCreateTask BlobContainer(string blobContainer = null)
        {
            WithArguments("--blob-container");
            if (!string.IsNullOrEmpty(blobContainer))
            {
                 WithArguments(blobContainer);
            }

            return this;
        }

        /// <summary>
        /// Name for capture destination.
        /// </summary>
        public AzureEventhubsEventhubCreateTask DestinationName(string destinationName = null)
        {
            WithArguments("--destination-name");
            if (!string.IsNullOrEmpty(destinationName))
            {
                 WithArguments(destinationName);
            }

            return this;
        }

        /// <summary>
        /// Name (if within same resource group and not of type Classic Storage) or ARM id of the storage account to be used to create the blobs.
        /// </summary>
        public AzureEventhubsEventhubCreateTask StorageAccount(string storageAccount = null)
        {
            WithArguments("--storage-account");
            if (!string.IsNullOrEmpty(storageAccount))
            {
                 WithArguments(storageAccount);
            }

            return this;
        }
     }
}
