
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusTopicAuthorizationRuleDeleteTask : ExternalProcessTaskBase<AzureServicebusTopicAuthorizationRuleDeleteTask>
     {
        
        /// <summary>
        /// Deletes the Authorization Rule of the given Service Bus Topic.
        /// </summary>
        public AzureServicebusTopicAuthorizationRuleDeleteTask(string name = null ,  string namespaceName = null ,  string resourceGroup = null ,  string topicName = null)
        {
            WithArguments("az servicebus topic authorization-rule delete");
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
        
     }
}
