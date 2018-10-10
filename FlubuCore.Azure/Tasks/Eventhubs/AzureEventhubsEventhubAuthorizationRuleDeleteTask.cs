
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventhubs
{
     public partial class AzureEventhubsEventhubAuthorizationRuleDeleteTask : ExternalProcessTaskBase<AzureEventhubsEventhubAuthorizationRuleDeleteTask>
     {
        
        /// <summary>
        /// Deletes the Authorizationrule of Eventhub.
        /// </summary>
        public AzureEventhubsEventhubAuthorizationRuleDeleteTask(string eventhubName = null ,  string name = null ,  string namespaceName = null ,  string resourceGroup = null)
        {
            WithArguments("az eventhubs eventhub authorization-rule delete");
WithArguments("--eventhub-name");
            if (!string.IsNullOrEmpty(eventhubName))
            {
                 WithArguments(eventhubName);
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

        }

        protected override string Description { get; set; }
        
     }
}
