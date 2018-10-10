
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkRouteTableRouteDeleteTask : ExternalProcessTaskBase<AzureNetworkRouteTableRouteDeleteTask>
     {
        
        /// <summary>
        /// Delete a route from a route table.
        /// </summary>
        public AzureNetworkRouteTableRouteDeleteTask(string name = null ,  string resourceGroup = null ,  string routeTableName = null)
        {
            WithArguments("az network route-table route delete");
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

WithArguments("--route-table-name");
            if (!string.IsNullOrEmpty(routeTableName))
            {
                 WithArguments(routeTableName);
            }

        }

        protected override string Description { get; set; }
        
     }
}
