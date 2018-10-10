
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusTopicUpdateTask : ExternalProcessTaskBase<AzureServicebusTopicUpdateTask>
     {
        
        /// <summary>
        /// Updates the Service Bus Topic.
        /// </summary>
        public AzureServicebusTopicUpdateTask(string name = null ,  string namespaceName = null ,  string resourceGroup = null)
        {
            WithArguments("az servicebus topic update");
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
        /// ISO 8601 timespan or duration time format for idle interval after which the topic is automatically deleted. The minimum duration is 5 minutes.
        /// </summary>
        public AzureServicebusTopicUpdateTask AutoDeleteOnIdle(string autoDeleteOnIdle = null)
        {
            WithArguments("--auto-delete-on-idle");
            if (!string.IsNullOrEmpty(autoDeleteOnIdle))
            {
                 WithArguments(autoDeleteOnIdle);
            }

            return this;
        }

        /// <summary>
        /// ISO 8601 or duration time format for Default message timespan to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself.
        /// </summary>
        public AzureServicebusTopicUpdateTask DefaultMessageTimeToLive(string defaultMessageTimeToLive = null)
        {
            WithArguments("--default-message-time-to-live");
            if (!string.IsNullOrEmpty(defaultMessageTimeToLive))
            {
                 WithArguments(defaultMessageTimeToLive);
            }

            return this;
        }

        /// <summary>
        /// ISO 8601 timespan or duration time format for structure that defines the duration of the duplicate detection history. The default value is 10 minutes.
        /// </summary>
        public AzureServicebusTopicUpdateTask DuplicateDetectionHistoryTimeWindow(string duplicateDetectionHistoryTimeWindow = null)
        {
            WithArguments("--duplicate-detection-history-time-window");
            if (!string.IsNullOrEmpty(duplicateDetectionHistoryTimeWindow))
            {
                 WithArguments(duplicateDetectionHistoryTimeWindow);
            }

            return this;
        }

        /// <summary>
        /// Allow server-side batched operations.
        /// </summary>
        public AzureServicebusTopicUpdateTask EnableBatchedOperations(string enableBatchedOperations = null)
        {
            WithArguments("--enable-batched-operations");
            if (!string.IsNullOrEmpty(enableBatchedOperations))
            {
                 WithArguments(enableBatchedOperations);
            }

            return this;
        }

        /// <summary>
        /// A boolean value indicating if this topic requires duplicate detection.
        /// </summary>
        public AzureServicebusTopicUpdateTask EnableDuplicateDetection(string enableDuplicateDetection = null)
        {
            WithArguments("--enable-duplicate-detection");
            if (!string.IsNullOrEmpty(enableDuplicateDetection))
            {
                 WithArguments(enableDuplicateDetection);
            }

            return this;
        }

        /// <summary>
        /// A boolean value that indicates whether Express Entities are enabled. An express topic holds a message in memory temporarily before writing it to persistent storage.
        /// </summary>
        public AzureServicebusTopicUpdateTask EnableExpress(string enableExpress = null)
        {
            WithArguments("--enable-express");
            if (!string.IsNullOrEmpty(enableExpress))
            {
                 WithArguments(enableExpress);
            }

            return this;
        }

        /// <summary>
        /// A boolean value that indicates whether the topic supports ordering.
        /// </summary>
        public AzureServicebusTopicUpdateTask EnableOrdering(string enableOrdering = null)
        {
            WithArguments("--enable-ordering");
            if (!string.IsNullOrEmpty(enableOrdering))
            {
                 WithArguments(enableOrdering);
            }

            return this;
        }

        /// <summary>
        /// A boolean value that indicates whether the topic to be partitioned across multiple message brokers is enabled.
        /// </summary>
        public AzureServicebusTopicUpdateTask EnablePartitioning(string enablePartitioning = null)
        {
            WithArguments("--enable-partitioning");
            if (!string.IsNullOrEmpty(enablePartitioning))
            {
                 WithArguments(enablePartitioning);
            }

            return this;
        }

        /// <summary>
        /// Maximum size of topic in megabytes, which is the size of the memory allocated for the topic. Default is 1024.
        /// </summary>
        public AzureServicebusTopicUpdateTask MaxSize(string maxSize = null)
        {
            WithArguments("--max-size");
            if (!string.IsNullOrEmpty(maxSize))
            {
                 WithArguments(maxSize);
            }

            return this;
        }

        /// <summary>
        /// Enumerates the possible values for the status of a messaging entity.
        /// </summary>
        public AzureServicebusTopicUpdateTask Status(string status = null)
        {
            WithArguments("--status");
            if (!string.IsNullOrEmpty(status))
            {
                 WithArguments(status);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureServicebusTopicUpdateTask Add(string add = null)
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
        public AzureServicebusTopicUpdateTask ForceString(string forceString = null)
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
        public AzureServicebusTopicUpdateTask Remove(string remove = null)
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
        public AzureServicebusTopicUpdateTask Set(string set = null)
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
