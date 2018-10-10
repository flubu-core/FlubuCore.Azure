
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkRouteFilterRuleDeleteTask : ExternalProcessTaskBase<AzureNetworkRouteFilterRuleDeleteTask>
     {
        
        /// <summary>
        /// Delete a rule from a route filter.
        /// </summary>
        public AzureNetworkRouteFilterRuleDeleteTask(string filterName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network route-filter rule delete");
WithArguments("--filter-name");
            if (!string.IsNullOrEmpty(filterName))
            {
                 WithArguments(filterName);
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
