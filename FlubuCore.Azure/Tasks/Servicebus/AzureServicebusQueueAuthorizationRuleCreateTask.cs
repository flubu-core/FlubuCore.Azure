
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusQueueAuthorizationRuleCreateTask : ExternalProcessTaskBase<AzureServicebusQueueAuthorizationRuleCreateTask>
     {
        
        /// <summary>
        /// Create Authorization Rule for the given Service Bus Queue.
        /// </summary>
        public AzureServicebusQueueAuthorizationRuleCreateTask(string name = null ,  string namespaceName = null ,  string queueName = null ,  string resourceGroup = null ,  string rights = null)
        {
            WithArguments("az servicebus queue authorization-rule create");
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

WithArguments("--rights");
            if (!string.IsNullOrEmpty(rights))
            {
                 WithArguments(rights);
            }

        }

        protected override string Description { get; set; }
        
     }
}
