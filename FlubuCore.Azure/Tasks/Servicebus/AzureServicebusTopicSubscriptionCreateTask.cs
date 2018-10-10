
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusTopicSubscriptionCreateTask : ExternalProcessTaskBase<AzureServicebusTopicSubscriptionCreateTask>
     {
        
        /// <summary>
        /// Create the ServiceBus Subscription.
        /// </summary>
        public AzureServicebusTopicSubscriptionCreateTask(string name = null ,  string namespaceName = null ,  string resourceGroup = null ,  string topicName = null)
        {
            WithArguments("az servicebus topic subscription create");
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

WithArguments("--topic-name");
            if (!string.IsNullOrEmpty(topicName))
            {
                 WithArguments(topicName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// ISO 8601 timeSpan  or duration time format for idle interval after which the topic is automatically deleted. The minimum duration is 5 minutes.
        /// </summary>
        public AzureServicebusTopicSubscriptionCreateTask AutoDeleteOnIdle(string autoDeleteOnIdle = null)
        {
            WithArguments("--auto-delete-on-idle");
            if (!string.IsNullOrEmpty(autoDeleteOnIdle))
            {
                 WithArguments(autoDeleteOnIdle);
            }

            return this;
        }

        /// <summary>
        /// Allow dead lettering when filter evaluation exceptions occur.
        /// </summary>
        public AzureServicebusTopicSubscriptionCreateTask DeadLetterOnFilterExceptions(string deadLetterOnFilterExceptions = null)
        {
            WithArguments("--dead-letter-on-filter-exceptions");
            if (!string.IsNullOrEmpty(deadLetterOnFilterExceptions))
            {
                 WithArguments(deadLetterOnFilterExceptions);
            }

            return this;
        }

        /// <summary>
        /// ISO 8601 or duration time format for Default message timespan to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself.
        /// </summary>
        public AzureServicebusTopicSubscriptionCreateTask DefaultMessageTimeToLive(string defaultMessageTimeToLive = null)
        {
            WithArguments("--default-message-time-to-live");
            if (!string.IsNullOrEmpty(defaultMessageTimeToLive))
            {
                 WithArguments(defaultMessageTimeToLive);
            }

            return this;
        }

        /// <summary>
        /// Allow server-side batched operations.
        /// </summary>
        public AzureServicebusTopicSubscriptionCreateTask EnableBatchedOperations(string enableBatchedOperations = null)
        {
            WithArguments("--enable-batched-operations");
            if (!string.IsNullOrEmpty(enableBatchedOperations))
            {
                 WithArguments(enableBatchedOperations);
            }

            return this;
        }

        /// <summary>
        /// A boolean Value that indicates whether a subscription has dead letter support when a message expires.
        /// </summary>
        public AzureServicebusTopicSubscriptionCreateTask EnableDeadLetteringOnMessageExpiration(string enableDeadLetteringOnMessageExpiration = null)
        {
            WithArguments("--enable-dead-lettering-on-message-expiration");
            if (!string.IsNullOrEmpty(enableDeadLetteringOnMessageExpiration))
            {
                 WithArguments(enableDeadLetteringOnMessageExpiration);
            }

            return this;
        }

        /// <summary>
        /// A boolean value indicating if a subscription supports the concept of sessions.
        /// </summary>
        public AzureServicebusTopicSubscriptionCreateTask EnableSession(string enableSession = null)
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
        public AzureServicebusTopicSubscriptionCreateTask ForwardDeadLetteredMessagesTo(string forwardDeadLetteredMessagesTo = null)
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
        public AzureServicebusTopicSubscriptionCreateTask ForwardTo(string forwardTo = null)
        {
            WithArguments("--forward-to");
            if (!string.IsNullOrEmpty(forwardTo))
            {
                 WithArguments(forwardTo);
            }

            return this;
        }

        /// <summary>
        /// ISO 8601 or duration format (day:minute:seconds) for lock duration timespan for the subscription. The default value is 1 minute.
        /// </summary>
        public AzureServicebusTopicSubscriptionCreateTask LockDuration(string lockDuration = null)
        {
            WithArguments("--lock-duration");
            if (!string.IsNullOrEmpty(lockDuration))
            {
                 WithArguments(lockDuration);
            }

            return this;
        }

        /// <summary>
        /// Number of maximum deliveries.
        /// </summary>
        public AzureServicebusTopicSubscriptionCreateTask MaxDeliveryCount(string maxDeliveryCount = null)
        {
            WithArguments("--max-delivery-count");
            if (!string.IsNullOrEmpty(maxDeliveryCount))
            {
                 WithArguments(maxDeliveryCount);
            }

            return this;
        }

        public AzureServicebusTopicSubscriptionCreateTask Status(string status = null)
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
