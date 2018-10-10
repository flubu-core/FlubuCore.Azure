
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusQueueCreateTask : ExternalProcessTaskBase<AzureServicebusQueueCreateTask>
     {
        
        /// <summary>
        /// Create the Service Bus Queue.
        /// </summary>
        public AzureServicebusQueueCreateTask(string name = null ,  string namespaceName = null ,  string resourceGroup = null)
        {
            WithArguments("az servicebus queue create");
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
        public AzureServicebusQueueCreateTask AutoDeleteOnIdle(string autoDeleteOnIdle = null)
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
        public AzureServicebusQueueCreateTask DefaultMessageTimeToLive(string defaultMessageTimeToLive = null)
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
        public AzureServicebusQueueCreateTask DuplicateDetectionHistoryTimeWindow(string duplicateDetectionHistoryTimeWindow = null)
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
        public AzureServicebusQueueCreateTask EnableBatchedOperations(string enableBatchedOperations = null)
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
        public AzureServicebusQueueCreateTask EnableDeadLetteringOnMessageExpiration(string enableDeadLetteringOnMessageExpiration = null)
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
        public AzureServicebusQueueCreateTask EnableDuplicateDetection(string enableDuplicateDetection = null)
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
        public AzureServicebusQueueCreateTask EnableExpress(string enableExpress = null)
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
        public AzureServicebusQueueCreateTask EnablePartitioning(string enablePartitioning = null)
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
        public AzureServicebusQueueCreateTask EnableSession(string enableSession = null)
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
        public AzureServicebusQueueCreateTask ForwardDeadLetteredMessagesTo(string forwardDeadLetteredMessagesTo = null)
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
        public AzureServicebusQueueCreateTask ForwardTo(string forwardTo = null)
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
        public AzureServicebusQueueCreateTask LockDuration(string lockDuration = null)
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
        public AzureServicebusQueueCreateTask MaxDeliveryCount(string maxDeliveryCount = null)
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
        public AzureServicebusQueueCreateTask MaxSize(string maxSize = null)
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
        public AzureServicebusQueueCreateTask Status(string status = null)
        {
            WithArguments("--status");
            if (!string.IsNullOrEmpty(status))
            {
                 WithArguments(status);
            }

            return this;
        }
     }
}
