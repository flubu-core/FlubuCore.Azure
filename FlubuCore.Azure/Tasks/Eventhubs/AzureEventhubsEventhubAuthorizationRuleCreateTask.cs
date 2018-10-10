
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventhubs
{
     public partial class AzureEventhubsEventhubAuthorizationRuleCreateTask : ExternalProcessTaskBase<AzureEventhubsEventhubAuthorizationRuleCreateTask>
     {
        
        /// <summary>
        /// Creates Authorizationrule for the given Eventhub.
        /// </summary>
        public AzureEventhubsEventhubAuthorizationRuleCreateTask(string eventhubName = null ,  string name = null ,  string namespaceName = null ,  string resourceGroup = null ,  string rights = null)
        {
            WithArguments("az eventhubs eventhub authorization-rule create");
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

WithArguments("--rights");
            if (!string.IsNullOrEmpty(rights))
            {
                 WithArguments(rights);
            }

        }

        protected override string Description { get; set; }
        
     }
}
