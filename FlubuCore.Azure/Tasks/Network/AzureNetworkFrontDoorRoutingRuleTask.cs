
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFrontDoorRoutingRuleTask : ExternalProcessTaskBase<AzureNetworkFrontDoorRoutingRuleTask>
     {
        
        /// <summary>
        /// Manage FrontDoor routing rules.
        /// </summary>
        public AzureNetworkFrontDoorRoutingRuleTask()
        {
            WithArguments("az network front-door routing-rule");
        }

        protected override string Description { get; set; }
        
     }
}
