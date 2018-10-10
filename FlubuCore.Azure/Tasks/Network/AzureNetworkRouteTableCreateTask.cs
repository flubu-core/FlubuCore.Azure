
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkRouteTableCreateTask : ExternalProcessTaskBase<AzureNetworkRouteTableCreateTask>
     {
        
        /// <summary>
        /// Create a route table.
        /// </summary>
        public AzureNetworkRouteTableCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network route-table create");
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
        /// Disable routes learned by BGP.
        /// </summary>
        public AzureNetworkRouteTableCreateTask DisableBgpRoutePropagation(string disableBgpRoutePropagation = null)
        {
            WithArguments("--disable-bgp-route-propagation");
            if (!string.IsNullOrEmpty(disableBgpRoutePropagation))
            {
                 WithArguments(disableBgpRoutePropagation);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureNetworkRouteTableCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureNetworkRouteTableCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }
     }
}
