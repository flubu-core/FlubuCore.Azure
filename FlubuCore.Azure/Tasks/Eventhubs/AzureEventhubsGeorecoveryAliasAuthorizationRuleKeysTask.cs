
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventhubs
{
     public partial class AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysTask : ExternalProcessTaskBase<AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysTask>
     {
        
        /// <summary>
        /// Manage Azure Event Hubs Authorizationrule connection strings for Geo Recovery configuration Alias.
        /// </summary>
        public AzureEventhubsGeorecoveryAliasAuthorizationRuleKeysTask()
        {
            WithArguments("az eventhubs georecovery-alias authorization-rule keys");
        }

        protected override string Description { get; set; }
        
     }
}
