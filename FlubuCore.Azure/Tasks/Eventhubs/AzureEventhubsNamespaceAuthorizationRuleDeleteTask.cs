
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventhubs
{
     public partial class AzureEventhubsNamespaceAuthorizationRuleDeleteTask : ExternalProcessTaskBase<AzureEventhubsNamespaceAuthorizationRuleDeleteTask>
     {
        
        /// <summary>
        /// Deletes the Authorizationrule of the namespace.
        /// </summary>
        public AzureEventhubsNamespaceAuthorizationRuleDeleteTask(string name = null ,  string namespaceName = null ,  string resourceGroup = null)
        {
            WithArguments("az eventhubs namespace authorization-rule delete");
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
