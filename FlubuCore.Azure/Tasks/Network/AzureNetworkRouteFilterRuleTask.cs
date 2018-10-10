
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkRouteFilterRuleTask : ExternalProcessTaskBase<AzureNetworkRouteFilterRuleTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage rules in a route filter.
        /// </summary>
        public AzureNetworkRouteFilterRuleTask()
        {
            WithArguments("az network route-filter rule");
        }

        protected override string Description { get; set; }
        
     }
}
