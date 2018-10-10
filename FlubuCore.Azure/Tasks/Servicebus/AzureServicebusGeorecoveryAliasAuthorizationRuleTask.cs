
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusGeorecoveryAliasAuthorizationRuleTask : ExternalProcessTaskBase<AzureServicebusGeorecoveryAliasAuthorizationRuleTask>
     {
        
        /// <summary>
        /// Manage Azure Service Bus Authorization Rule for Namespace with Geo-Disaster Recovery Configuration Alias.
        /// </summary>
        public AzureServicebusGeorecoveryAliasAuthorizationRuleTask()
        {
            WithArguments("az servicebus georecovery-alias authorization-rule");
        }

        protected override string Description { get; set; }
        
     }
}
