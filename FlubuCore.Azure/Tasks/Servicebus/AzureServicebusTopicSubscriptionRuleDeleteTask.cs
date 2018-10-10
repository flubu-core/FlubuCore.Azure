
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusTopicSubscriptionRuleDeleteTask : ExternalProcessTaskBase<AzureServicebusTopicSubscriptionRuleDeleteTask>
     {
        
        /// <summary>
        /// Deletes the ServiceBus Rule.
        /// </summary>
        public AzureServicebusTopicSubscriptionRuleDeleteTask(string name = null ,  string namespaceName = null ,  string resourceGroup = null ,  string subscriptionName = null ,  string topicName = null)
        {
            WithArguments("az servicebus topic subscription rule delete");
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
        
     }
}
