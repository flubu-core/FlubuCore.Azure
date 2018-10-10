
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayRuleTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayRuleTask>
     {
        
        /// <summary>
        /// Evaluate probe information and define routing rules.
        /// </summary>
        public AzureNetworkApplicationGatewayRuleTask()
        {
            WithArguments("az network application-gateway rule");
        }

        protected override string Description { get; set; }
        
     }
}
