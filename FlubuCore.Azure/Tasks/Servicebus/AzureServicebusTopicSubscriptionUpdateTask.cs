
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusTopicSubscriptionUpdateTask : ExternalProcessTaskBase<AzureServicebusTopicSubscriptionUpdateTask>
     {
        
        /// <summary>
        /// Updates the ServiceBus Subscription.
        /// </summary>
        public AzureServicebusTopicSubscriptionUpdateTask(string name = null ,  string namespaceName = null ,  string resourceGroup = null ,  string topicName = null)
        {
            WithArguments("az servicebus topic subscription update");
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
        public AzureServicebusTopicSubscriptionUpdateTask AutoDeleteOnIdle(string autoDeleteOnIdle = null)
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
        public AzureServicebusTopicSubscriptionUpdateTask DeadLetterOnFilterExceptions(string deadLetterOnFilterExceptions = null)
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
        public AzureServicebusTopicSubscriptionUpdateTask DefaultMessageTimeToLive(string defaultMessageTimeToLive = null)
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
        public AzureServicebusTopicSubscriptionUpdateTask EnableBatchedOperations(string enableBatchedOperations = null)
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
        public AzureServicebusTopicSubscriptionUpdateTask EnableDeadLetteringOnMessageExpiration(string enableDeadLetteringOnMessageExpiration = null)
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
        public AzureServicebusTopicSubscriptionUpdateTask EnableSession(string enableSession = null)
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
        public AzureServicebusTopicSubscriptionUpdateTask ForwardDeadLetteredMessagesTo(string forwardDeadLetteredMessagesTo = null)
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
        public AzureServicebusTopicSubscriptionUpdateTask ForwardTo(string forwardTo = null)
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
        public AzureServicebusTopicSubscriptionUpdateTask LockDuration(string lockDuration = null)
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
        public AzureServicebusTopicSubscriptionUpdateTask MaxDeliveryCount(string maxDeliveryCount = null)
        {
            WithArguments("--max-delivery-count");
            if (!string.IsNullOrEmpty(maxDeliveryCount))
            {
                 WithArguments(maxDeliveryCount);
            }

            return this;
        }

        public AzureServicebusTopicSubscriptionUpdateTask Status(string status = null)
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
        public AzureServicebusTopicSubscriptionUpdateTask Add(string add = null)
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
        public AzureServicebusTopicSubscriptionUpdateTask ForceString(string forceString = null)
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
        public AzureServicebusTopicSubscriptionUpdateTask Remove(string remove = null)
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
        public AzureServicebusTopicSubscriptionUpdateTask Set(string set = null)
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
