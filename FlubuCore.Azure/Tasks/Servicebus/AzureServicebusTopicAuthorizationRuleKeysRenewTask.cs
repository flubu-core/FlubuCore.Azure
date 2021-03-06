
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusTopicAuthorizationRuleKeysRenewTask : ExternalProcessTaskBase<AzureServicebusTopicAuthorizationRuleKeysRenewTask>
     {
        
        /// <summary>
        /// Regenerate keys of Authorization Rule for Service Bus Topic.
        /// </summary>
        public AzureServicebusTopicAuthorizationRuleKeysRenewTask(string key = null ,  string name = null ,  string namespaceName = null ,  string resourceGroup = null ,  string topicName = null)
        {
            WithArguments("az servicebus topic authorization-rule keys renew");
WithArguments("--key");
            if (!string.IsNullOrEmpty(key))
            {
                 WithArguments(key);
            }

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
        /// Optional, if the key value provided, is set for KeyType or autogenerated Key value set for keyType.
        /// </summary>
        public AzureServicebusTopicAuthorizationRuleKeysRenewTask KeyValue(string keyValue = null)
        {
            WithArguments("--key-value");
            if (!string.IsNullOrEmpty(keyValue))
            {
                 WithArguments(keyValue);
            }

            return this;
        }
     }
}
