
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkExpressRoutePortCreateTask : ExternalProcessTaskBase<AzureNetworkExpressRoutePortCreateTask>
     {
        
        /// <summary>
        /// Create an ExpressRoute port.
        /// </summary>
        public AzureNetworkExpressRoutePortCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network express-route port create");
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
        /// Bandwidth of procured ports in Gbps.
        /// </summary>
        public AzureNetworkExpressRoutePortCreateTask Bandwidth(string bandwidth = null)
        {
            WithArguments("--bandwidth");
            if (!string.IsNullOrEmpty(bandwidth))
            {
                 WithArguments(bandwidth);
            }

            return this;
        }

        /// <summary>
        /// Encapsulation method on physical ports.
        /// </summary>
        public AzureNetworkExpressRoutePortCreateTask Encapsulation(string encapsulation = null)
        {
            WithArguments("--encapsulation");
            if (!string.IsNullOrEmpty(encapsulation))
            {
                 WithArguments(encapsulation);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureNetworkExpressRoutePortCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// The name of the peering location that the port is mapped to physically.
        /// </summary>
        public AzureNetworkExpressRoutePortCreateTask PeeringLocation(string peeringLocation = null)
        {
            WithArguments("--peering-location");
            if (!string.IsNullOrEmpty(peeringLocation))
            {
                 WithArguments(peeringLocation);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureNetworkExpressRoutePortCreateTask Tags(string tags = null)
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
