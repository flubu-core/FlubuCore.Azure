
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkExpressRoutePortDeleteTask : ExternalProcessTaskBase<AzureNetworkExpressRoutePortDeleteTask>
     {
        
        /// <summary>
        /// Delete an ExpressRoute port.
        /// </summary>
        public AzureNetworkExpressRoutePortDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network express-route port delete");
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
