
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkRouteTableDeleteTask : ExternalProcessTaskBase<AzureNetworkRouteTableDeleteTask>
     {
        
        /// <summary>
        /// Delete a route table.
        /// </summary>
        public AzureNetworkRouteTableDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network route-table delete");
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
