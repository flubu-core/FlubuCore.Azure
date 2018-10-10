
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Relay
{
     public partial class AzureRelayWcfrelayAuthorizationRuleKeysRenewTask : ExternalProcessTaskBase<AzureRelayWcfrelayAuthorizationRuleKeysRenewTask>
     {
        
        /// <summary>
        /// Regenerate keys of Authorization Rule for Relay Service WCF Relay.
        /// </summary>
        public AzureRelayWcfrelayAuthorizationRuleKeysRenewTask(string key = null ,  string name = null ,  string namespaceName = null ,  string relayName = null ,  string resourceGroup = null)
        {
            WithArguments("az relay wcfrelay authorization-rule keys renew");
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

WithArguments("--relay-name");
            if (!string.IsNullOrEmpty(relayName))
            {
                 WithArguments(relayName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Optional, if the key value provided, is set for KeyType or autogenerated Key value set for keyType.
        /// </summary>
        public AzureRelayWcfrelayAuthorizationRuleKeysRenewTask KeyValue(string keyValue = null)
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