
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventhubs
{
     public partial class AzureEventhubsEventhubAuthorizationRuleKeysTask : ExternalProcessTaskBase<AzureEventhubsEventhubAuthorizationRuleKeysTask>
     {
        
        /// <summary>
        /// Manage Azure Authorizationrule connection strings for Eventhub.
        /// </summary>
        public AzureEventhubsEventhubAuthorizationRuleKeysTask()
        {
            WithArguments("az eventhubs eventhub authorization-rule keys");
        }

        protected override string Description { get; set; }
        
     }
}
