
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkRouteFilterDeleteTask : ExternalProcessTaskBase<AzureNetworkRouteFilterDeleteTask>
     {
        
        /// <summary>
        /// Delete a route filter.
        /// </summary>
        public AzureNetworkRouteFilterDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network route-filter delete");
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
