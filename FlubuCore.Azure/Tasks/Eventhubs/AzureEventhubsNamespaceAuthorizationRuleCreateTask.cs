
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventhubs
{
     public partial class AzureEventhubsNamespaceAuthorizationRuleCreateTask : ExternalProcessTaskBase<AzureEventhubsNamespaceAuthorizationRuleCreateTask>
     {
        
        /// <summary>
        /// Creates Authorizationrule for the given Namespace.
        /// </summary>
        public AzureEventhubsNamespaceAuthorizationRuleCreateTask(string name = null ,  string namespaceName = null ,  string resourceGroup = null ,  string rights = null)
        {
            WithArguments("az eventhubs namespace authorization-rule create");
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

WithArguments("--rights");
            if (!string.IsNullOrEmpty(rights))
            {
                 WithArguments(rights);
            }

        }

        protected override string Description { get; set; }
        
     }
}
