
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventhubs
{
     public partial class AzureEventhubsGeorecoveryAliasAuthorizationRuleTask : ExternalProcessTaskBase<AzureEventhubsGeorecoveryAliasAuthorizationRuleTask>
     {
        
        /// <summary>
        /// Manage Azure Event Hubs Authorizationrule for Geo Recovery configuration Alias.
        /// </summary>
        public AzureEventhubsGeorecoveryAliasAuthorizationRuleTask()
        {
            WithArguments("az eventhubs georecovery-alias authorization-rule");
        }

        protected override string Description { get; set; }
        
     }
}
