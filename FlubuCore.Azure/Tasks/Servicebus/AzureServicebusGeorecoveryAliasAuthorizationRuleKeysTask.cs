
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusGeorecoveryAliasAuthorizationRuleKeysTask : ExternalProcessTaskBase<AzureServicebusGeorecoveryAliasAuthorizationRuleKeysTask>
     {
        
        /// <summary>
        /// Manage Azure Authorization Rule keys for Service Bus Namespace.
        /// </summary>
        public AzureServicebusGeorecoveryAliasAuthorizationRuleKeysTask()
        {
            WithArguments("az servicebus georecovery-alias authorization-rule keys");
        }

        protected override string Description { get; set; }
        
     }
}
