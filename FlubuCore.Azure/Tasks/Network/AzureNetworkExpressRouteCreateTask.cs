
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkExpressRouteCreateTask : ExternalProcessTaskBase<AzureNetworkExpressRouteCreateTask>
     {
        
        /// <summary>
        /// Create an ExpressRoute circuit.
        /// </summary>
        public AzureNetworkExpressRouteCreateTask(string bandwidth = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network express-route create");
WithArguments("--bandwidth");
            if (!string.IsNullOrEmpty(bandwidth))
            {
                 WithArguments(bandwidth);
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
        /// Enable global reach on the circuit.
        /// </summary>
        public AzureNetworkExpressRouteCreateTask AllowGlobalReach(string allowGlobalReach = null)
        {
            WithArguments("--allow-global-reach");
            if (!string.IsNullOrEmpty(allowGlobalReach))
            {
                 WithArguments(allowGlobalReach);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of an ExpressRoute port.
        /// </summary>
        public AzureNetworkExpressRouteCreateTask ExpressRoutePort(string expressRoutePort = null)
        {
            WithArguments("--express-route-port");
            if (!string.IsNullOrEmpty(expressRoutePort))
            {
                 WithArguments(expressRoutePort);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureNetworkExpressRouteCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkExpressRouteCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Name of the peering location.
        /// </summary>
        public AzureNetworkExpressRouteCreateTask PeeringLocation(string peeringLocation = null)
        {
            WithArguments("--peering-location");
            if (!string.IsNullOrEmpty(peeringLocation))
            {
                 WithArguments(peeringLocation);
            }

            return this;
        }

        /// <summary>
        /// Name of the ExpressRoute Service Provider.
        /// </summary>
        public AzureNetworkExpressRouteCreateTask Provider(string provider = null)
        {
            WithArguments("--provider");
            if (!string.IsNullOrEmpty(provider))
            {
                 WithArguments(provider);
            }

            return this;
        }

        /// <summary>
        /// Chosen SKU family of ExpressRoute circuit.
        /// </summary>
        public AzureNetworkExpressRouteCreateTask SkuFamily(string skuFamily = null)
        {
            WithArguments("--sku-family");
            if (!string.IsNullOrEmpty(skuFamily))
            {
                 WithArguments(skuFamily);
            }

            return this;
        }

        /// <summary>
        /// SKU Tier of ExpressRoute circuit.
        /// </summary>
        public AzureNetworkExpressRouteCreateTask SkuTier(string skuTier = null)
        {
            WithArguments("--sku-tier");
            if (!string.IsNullOrEmpty(skuTier))
            {
                 WithArguments(skuTier);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureNetworkExpressRouteCreateTask Tags(string tags = null)
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
