
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFrontDoorRoutingRuleDeleteTask : ExternalProcessTaskBase<AzureNetworkFrontDoorRoutingRuleDeleteTask>
     {
        
        /// <summary>
        /// Delete a FrontDoor routing rule.
        /// </summary>
        public AzureNetworkFrontDoorRoutingRuleDeleteTask(string frontDoorName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network front-door routing-rule delete");
WithArguments("--front-door-name");
            if (!string.IsNullOrEmpty(frontDoorName))
            {
                 WithArguments(frontDoorName);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
     }
}
