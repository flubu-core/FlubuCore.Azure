
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkApplicationGatewayUrlPathMapRuleDeleteTask : ExternalProcessTaskBase<AzureNetworkApplicationGatewayUrlPathMapRuleDeleteTask>
     {
        
        /// <summary>
        /// Delete a rule of a URL path map.
        /// </summary>
        public AzureNetworkApplicationGatewayUrlPathMapRuleDeleteTask(string gatewayName = null ,  string name = null ,  string pathMapName = null ,  string resourceGroup = null)
        {
            WithArguments("az network application-gateway url-path-map rule delete");
WithArguments("--gateway-name");
            if (!string.IsNullOrEmpty(gatewayName))
            {
                 WithArguments(gatewayName);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--path-map-name");
            if (!string.IsNullOrEmpty(pathMapName))
            {
                 WithArguments(pathMapName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkApplicationGatewayUrlPathMapRuleDeleteTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }
     }
}
