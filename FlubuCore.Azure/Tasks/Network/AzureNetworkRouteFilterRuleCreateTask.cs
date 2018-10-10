
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkRouteFilterRuleCreateTask : ExternalProcessTaskBase<AzureNetworkRouteFilterRuleCreateTask>
     {
        
        /// <summary>
        /// Create a rule in a route filter.
        /// </summary>
        public AzureNetworkRouteFilterRuleCreateTask(string access = null ,  string communities = null ,  string filterName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network route-filter rule create");
WithArguments("--access");
            if (!string.IsNullOrEmpty(access))
            {
                 WithArguments(access);
            }

WithArguments("--communities");
            if (!string.IsNullOrEmpty(communities))
            {
                 WithArguments(communities);
            }

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
        
        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureNetworkRouteFilterRuleCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }
     }
}
