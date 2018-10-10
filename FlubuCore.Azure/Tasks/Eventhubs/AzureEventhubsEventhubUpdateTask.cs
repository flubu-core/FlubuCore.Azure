
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventhubs
{
     public partial class AzureEventhubsEventhubUpdateTask : ExternalProcessTaskBase<AzureEventhubsEventhubUpdateTask>
     {
        
        /// <summary>
        /// Updates the Event Hubs Eventhub.
        /// </summary>
        public AzureEventhubsEventhubUpdateTask(string name = null ,  string namespaceName = null ,  string resourceGroup = null)
        {
            WithArguments("az eventhubs eventhub update");
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
        public AzureEventhubsEventhubUpdateTask EnableCapture(string enableCapture = null)
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
        public AzureEventhubsEventhubUpdateTask MessageRetention(string messageRetention = null)
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
        public AzureEventhubsEventhubUpdateTask PartitionCount(string partitionCount = null)
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
        public AzureEventhubsEventhubUpdateTask Status(string status = null)
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
        public AzureEventhubsEventhubUpdateTask CaptureInterval(string captureInterval = null)
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
        public AzureEventhubsEventhubUpdateTask CaptureSizeLimit(string captureSizeLimit = null)
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
        public AzureEventhubsEventhubUpdateTask ArchiveNameFormat(string archiveNameFormat = null)
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
        public AzureEventhubsEventhubUpdateTask BlobContainer(string blobContainer = null)
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
        public AzureEventhubsEventhubUpdateTask DestinationName(string destinationName = null)
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
        public AzureEventhubsEventhubUpdateTask StorageAccount(string storageAccount = null)
        {
            WithArguments("--storage-account");
            if (!string.IsNullOrEmpty(storageAccount))
            {
                 WithArguments(storageAccount);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureEventhubsEventhubUpdateTask Add(string add = null)
        {
            WithArguments("--add");
            if (!string.IsNullOrEmpty(add))
            {
                 WithArguments(add);
            }

            return this;
        }

        /// <summary>
        /// When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.
        /// </summary>
        public AzureEventhubsEventhubUpdateTask ForceString(string forceString = null)
        {
            WithArguments("--force-string");
            if (!string.IsNullOrEmpty(forceString))
            {
                 WithArguments(forceString);
            }

            return this;
        }

        /// <summary>
        /// Remove a property or an element from a list.  Example: --remove property.list <indexToRemove> OR --remove propertyToRemove.
        /// </summary>
        public AzureEventhubsEventhubUpdateTask Remove(string remove = null)
        {
            WithArguments("--remove");
            if (!string.IsNullOrEmpty(remove))
            {
                 WithArguments(remove);
            }

            return this;
        }

        /// <summary>
        /// Update an object by specifying a property path and value to set.  Example: --set property1.property2=<value>.
        /// </summary>
        public AzureEventhubsEventhubUpdateTask Set(string set = null)
        {
            WithArguments("--set");
            if (!string.IsNullOrEmpty(set))
            {
                 WithArguments(set);
            }

            return this;
        }
     }
}
