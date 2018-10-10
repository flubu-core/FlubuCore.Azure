
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusQueueAuthorizationRuleDeleteTask : ExternalProcessTaskBase<AzureServicebusQueueAuthorizationRuleDeleteTask>
     {
        
        /// <summary>
        /// Delete the Authorization Rule of Service Bus Queue.
        /// </summary>
        public AzureServicebusQueueAuthorizationRuleDeleteTask(string name = null ,  string namespaceName = null ,  string queueName = null ,  string resourceGroup = null)
        {
            WithArguments("az servicebus queue authorization-rule delete");
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

WithArguments("--queue-name");
            if (!string.IsNullOrEmpty(queueName))
            {
                 WithArguments(queueName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
     }
}
