
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusQueueUpdateTask : ExternalProcessTaskBase<AzureServicebusQueueUpdateTask>
     {
        
        /// <summary>
        /// Updates existing Service Bus Queue.
        /// </summary>
        public AzureServicebusQueueUpdateTask(string name = null ,  string namespaceName = null ,  string resourceGroup = null)
        {
            WithArguments("az servicebus queue update");
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
        /// ISO 8601 timeSpan or duration time format for idle interval after which the queue is automatically deleted. The minimum duration is 5 minutes.
        /// </summary>
        public AzureServicebusQueueUpdateTask AutoDeleteOnIdle(string autoDeleteOnIdle = null)
        {
            WithArguments("--auto-delete-on-idle");
            if (!string.IsNullOrEmpty(autoDeleteOnIdle))
            {
                 WithArguments(autoDeleteOnIdle);
            }

            return this;
        }

        /// <summary>
        /// ISO 8601 timespan or duration time format for default message to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself.
        /// </summary>
        public AzureServicebusQueueUpdateTask DefaultMessageTimeToLive(string defaultMessageTimeToLive = null)
        {
            WithArguments("--default-message-time-to-live");
            if (!string.IsNullOrEmpty(defaultMessageTimeToLive))
            {
                 WithArguments(defaultMessageTimeToLive);
            }

            return this;
        }

        /// <summary>
        /// ISO 8601 timeSpan structure that defines the duration of the duplicate detection history. The default value is 10 minutes.
        /// </summary>
        public AzureServicebusQueueUpdateTask DuplicateDetectionHistoryTimeWindow(string duplicateDetectionHistoryTimeWindow = null)
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
        public AzureServicebusQueueUpdateTask EnableBatchedOperations(string enableBatchedOperations = null)
        {
            WithArguments("--enable-batched-operations");
            if (!string.IsNullOrEmpty(enableBatchedOperations))
            {
                 WithArguments(enableBatchedOperations);
            }

            return this;
        }

        /// <summary>
        /// A boolean value that indicates whether this queue has dead letter support when a message expires.
        /// </summary>
        public AzureServicebusQueueUpdateTask EnableDeadLetteringOnMessageExpiration(string enableDeadLetteringOnMessageExpiration = null)
        {
            WithArguments("--enable-dead-lettering-on-message-expiration");
            if (!string.IsNullOrEmpty(enableDeadLetteringOnMessageExpiration))
            {
                 WithArguments(enableDeadLetteringOnMessageExpiration);
            }

            return this;
        }

        /// <summary>
        /// A boolean value indicating if this queue requires duplicate detection.
        /// </summary>
        public AzureServicebusQueueUpdateTask EnableDuplicateDetection(string enableDuplicateDetection = null)
        {
            WithArguments("--enable-duplicate-detection");
            if (!string.IsNullOrEmpty(enableDuplicateDetection))
            {
                 WithArguments(enableDuplicateDetection);
            }

            return this;
        }

        /// <summary>
        /// A boolean value that indicates whether Express Entities are enabled. An express queue holds a message in memory temporarily before writing it to persistent storage.
        /// </summary>
        public AzureServicebusQueueUpdateTask EnableExpress(string enableExpress = null)
        {
            WithArguments("--enable-express");
            if (!string.IsNullOrEmpty(enableExpress))
            {
                 WithArguments(enableExpress);
            }

            return this;
        }

        /// <summary>
        /// A boolean value that indicates whether the queue is to be partitioned across multiple message brokers.
        /// </summary>
        public AzureServicebusQueueUpdateTask EnablePartitioning(string enablePartitioning = null)
        {
            WithArguments("--enable-partitioning");
            if (!string.IsNullOrEmpty(enablePartitioning))
            {
                 WithArguments(enablePartitioning);
            }

            return this;
        }

        /// <summary>
        /// A boolean value indicating whether the queue supports the concept of sessions.
        /// </summary>
        public AzureServicebusQueueUpdateTask EnableSession(string enableSession = null)
        {
            WithArguments("--enable-session");
            if (!string.IsNullOrEmpty(enableSession))
            {
                 WithArguments(enableSession);
            }

            return this;
        }

        /// <summary>
        /// Queue/Topic name to forward the Dead Letter message.
        /// </summary>
        public AzureServicebusQueueUpdateTask ForwardDeadLetteredMessagesTo(string forwardDeadLetteredMessagesTo = null)
        {
            WithArguments("--forward-dead-lettered-messages-to");
            if (!string.IsNullOrEmpty(forwardDeadLetteredMessagesTo))
            {
                 WithArguments(forwardDeadLetteredMessagesTo);
            }

            return this;
        }

        /// <summary>
        /// Queue/Topic name to forward the messages.
        /// </summary>
        public AzureServicebusQueueUpdateTask ForwardTo(string forwardTo = null)
        {
            WithArguments("--forward-to");
            if (!string.IsNullOrEmpty(forwardTo))
            {
                 WithArguments(forwardTo);
            }

            return this;
        }

        /// <summary>
        /// String ISO 8601 timespan or duration format for duration of a peek-lock; that is, the amount of time that the message is locked for other receivers. The maximum value for LockDuration is 5 minutes; the default value is 1 minute.
        /// </summary>
        public AzureServicebusQueueUpdateTask LockDuration(string lockDuration = null)
        {
            WithArguments("--lock-duration");
            if (!string.IsNullOrEmpty(lockDuration))
            {
                 WithArguments(lockDuration);
            }

            return this;
        }

        /// <summary>
        /// The maximum delivery count. A message is automatically deadlettered after this number of deliveries. default value is 10.
        /// </summary>
        public AzureServicebusQueueUpdateTask MaxDeliveryCount(string maxDeliveryCount = null)
        {
            WithArguments("--max-delivery-count");
            if (!string.IsNullOrEmpty(maxDeliveryCount))
            {
                 WithArguments(maxDeliveryCount);
            }

            return this;
        }

        /// <summary>
        /// The maximum size of queue in megabytes, which is the size of memory allocated for the queue. Default is 1024.
        /// </summary>
        public AzureServicebusQueueUpdateTask MaxSize(string maxSize = null)
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
        public AzureServicebusQueueUpdateTask Status(string status = null)
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
        public AzureServicebusQueueUpdateTask Add(string add = null)
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
        public AzureServicebusQueueUpdateTask ForceString(string forceString = null)
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
        public AzureServicebusQueueUpdateTask Remove(string remove = null)
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
        public AzureServicebusQueueUpdateTask Set(string set = null)
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
