
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusNamespaceAuthorizationRuleDeleteTask : ExternalProcessTaskBase<AzureServicebusNamespaceAuthorizationRuleDeleteTask>
     {
        
        /// <summary>
        /// Deletes the Authorization Rule of the Service Bus Namespace.
        /// </summary>
        public AzureServicebusNamespaceAuthorizationRuleDeleteTask(string name = null ,  string namespaceName = null ,  string resourceGroup = null)
        {
            WithArguments("az servicebus namespace authorization-rule delete");
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
        
     }
}
