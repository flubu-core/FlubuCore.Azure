
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayUrlPathMapRuleTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayUrlPathMapRuleTask>
     {
        
        /// <summary>
        /// Manage the rules of a URL path map.
        /// </summary>
        public AzureNetworkApplicationGatewayUrlPathMapRuleTask()
        {
            WithArguments("az network application-gateway url-path-map rule");
        }

        protected override string Description { get; set; }
        
     }
}
