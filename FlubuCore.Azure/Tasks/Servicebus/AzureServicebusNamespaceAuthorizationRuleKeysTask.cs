
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusNamespaceAuthorizationRuleKeysTask : ExternalProcessTaskBase<AzureServicebusNamespaceAuthorizationRuleKeysTask>
     {
        
        /// <summary>
        /// Manage Azure Authorization Rule connection strings for Namespace.
        /// </summary>
        public AzureServicebusNamespaceAuthorizationRuleKeysTask()
        {
            WithArguments("az servicebus namespace authorization-rule keys");
        }

        protected override string Description { get; set; }
        
     }
}
