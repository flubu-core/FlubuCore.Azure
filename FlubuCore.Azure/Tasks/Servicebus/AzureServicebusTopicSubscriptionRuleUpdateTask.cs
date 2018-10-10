
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusTopicSubscriptionRuleUpdateTask : ExternalProcessTaskBase<AzureServicebusTopicSubscriptionRuleUpdateTask>
     {
        
        /// <summary>
        /// Updates the ServiceBus Rule for Subscription.
        /// </summary>
        public AzureServicebusTopicSubscriptionRuleUpdateTask(string name = null ,  string namespaceName = null ,  string resourceGroup = null ,  string subscriptionName = null ,  string topicName = null)
        {
            WithArguments("az servicebus topic subscription rule update");
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

WithArguments("--subscription-name");
            if (!string.IsNullOrEmpty(subscriptionName))
            {
                 WithArguments(subscriptionName);
            }

WithArguments("--topic-name");
            if (!string.IsNullOrEmpty(topicName))
            {
                 WithArguments(topicName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// This property is reserved for future use. An integer value showing the compatibility level, currently hard-coded to 20.
        /// </summary>
        public AzureServicebusTopicSubscriptionRuleUpdateTask ActionCompatibilityLevel(string actionCompatibilityLevel = null)
        {
            WithArguments("--action-compatibility-level");
            if (!string.IsNullOrEmpty(actionCompatibilityLevel))
            {
                 WithArguments(actionCompatibilityLevel);
            }

            return this;
        }

        /// <summary>
        /// Action SQL expression.
        /// </summary>
        public AzureServicebusTopicSubscriptionRuleUpdateTask ActionSqlExpression(string actionSqlExpression = null)
        {
            WithArguments("--action-sql-expression");
            if (!string.IsNullOrEmpty(actionSqlExpression))
            {
                 WithArguments(actionSqlExpression);
            }

            return this;
        }

        /// <summary>
        /// A boolean value that indicates whether the rule action requires preprocessing.
        /// </summary>
        public AzureServicebusTopicSubscriptionRuleUpdateTask EnableActionPreprocessing(string enableActionPreprocessing = null)
        {
            WithArguments("--enable-action-preprocessing");
            if (!string.IsNullOrEmpty(enableActionPreprocessing))
            {
                 WithArguments(enableActionPreprocessing);
            }

            return this;
        }

        /// <summary>
        /// Content type of message.
        /// </summary>
        public AzureServicebusTopicSubscriptionRuleUpdateTask ContentType(string contentType = null)
        {
            WithArguments("--content-type");
            if (!string.IsNullOrEmpty(contentType))
            {
                 WithArguments(contentType);
            }

            return this;
        }

        /// <summary>
        /// Identifier of correlation.
        /// </summary>
        public AzureServicebusTopicSubscriptionRuleUpdateTask CorrelationId(string correlationId = null)
        {
            WithArguments("--correlation-id");
            if (!string.IsNullOrEmpty(correlationId))
            {
                 WithArguments(correlationId);
            }

            return this;
        }

        /// <summary>
        /// A boolean value that indicates whether the rule action requires preprocessing.
        /// </summary>
        public AzureServicebusTopicSubscriptionRuleUpdateTask EnableCorrelationPreprocessing(string enableCorrelationPreprocessing = null)
        {
            WithArguments("--enable-correlation-preprocessing");
            if (!string.IsNullOrEmpty(enableCorrelationPreprocessing))
            {
                 WithArguments(enableCorrelationPreprocessing);
            }

            return this;
        }

        /// <summary>
        /// Application specific label.
        /// </summary>
        public AzureServicebusTopicSubscriptionRuleUpdateTask Label(string label = null)
        {
            WithArguments("--label");
            if (!string.IsNullOrEmpty(label))
            {
                 WithArguments(label);
            }

            return this;
        }

        /// <summary>
        /// Identifier of message.
        /// </summary>
        public AzureServicebusTopicSubscriptionRuleUpdateTask MessageId(string messageId = null)
        {
            WithArguments("--message-id");
            if (!string.IsNullOrEmpty(messageId))
            {
                 WithArguments(messageId);
            }

            return this;
        }

        /// <summary>
        /// Address of the queue to reply to.
        /// </summary>
        public AzureServicebusTopicSubscriptionRuleUpdateTask ReplyTo(string replyTo = null)
        {
            WithArguments("--reply-to");
            if (!string.IsNullOrEmpty(replyTo))
            {
                 WithArguments(replyTo);
            }

            return this;
        }

        /// <summary>
        /// Session identifier to reply to.
        /// </summary>
        public AzureServicebusTopicSubscriptionRuleUpdateTask ReplyToSessionId(string replyToSessionId = null)
        {
            WithArguments("--reply-to-session-id");
            if (!string.IsNullOrEmpty(replyToSessionId))
            {
                 WithArguments(replyToSessionId);
            }

            return this;
        }

        /// <summary>
        /// Session identifier.
        /// </summary>
        public AzureServicebusTopicSubscriptionRuleUpdateTask SessionId(string sessionId = null)
        {
            WithArguments("--session-id");
            if (!string.IsNullOrEmpty(sessionId))
            {
                 WithArguments(sessionId);
            }

            return this;
        }

        /// <summary>
        /// Address to send to.
        /// </summary>
        public AzureServicebusTopicSubscriptionRuleUpdateTask To(string to = null)
        {
            WithArguments("--to");
            if (!string.IsNullOrEmpty(to))
            {
                 WithArguments(to);
            }

            return this;
        }

        /// <summary>
        /// A boolean value that indicates whether the rule action requires preprocessing.
        /// </summary>
        public AzureServicebusTopicSubscriptionRuleUpdateTask EnableSqlPreprocessing(string enableSqlPreprocessing = null)
        {
            WithArguments("--enable-sql-preprocessing");
            if (!string.IsNullOrEmpty(enableSqlPreprocessing))
            {
                 WithArguments(enableSqlPreprocessing);
            }

            return this;
        }

        /// <summary>
        /// SQL expression. e.g. myproperty=test.
        /// </summary>
        public AzureServicebusTopicSubscriptionRuleUpdateTask FilterSqlExpression(string filterSqlExpression = null)
        {
            WithArguments("--filter-sql-expression");
            if (!string.IsNullOrEmpty(filterSqlExpression))
            {
                 WithArguments(filterSqlExpression);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureServicebusTopicSubscriptionRuleUpdateTask Add(string add = null)
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
        public AzureServicebusTopicSubscriptionRuleUpdateTask ForceString(string forceString = null)
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
        public AzureServicebusTopicSubscriptionRuleUpdateTask Remove(string remove = null)
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
        public AzureServicebusTopicSubscriptionRuleUpdateTask Set(string set = null)
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
