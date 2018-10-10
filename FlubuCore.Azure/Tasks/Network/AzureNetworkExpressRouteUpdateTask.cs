
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkExpressRouteUpdateTask : ExternalProcessTaskBase<AzureNetworkExpressRouteUpdateTask>
     {
        
        /// <summary>
        /// Update settings of an ExpressRoute circuit.
        /// </summary>
        public AzureNetworkExpressRouteUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network express-route update");
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
        public AzureNetworkExpressRouteUpdateTask AllowGlobalReach(string allowGlobalReach = null)
        {
            WithArguments("--allow-global-reach");
            if (!string.IsNullOrEmpty(allowGlobalReach))
            {
                 WithArguments(allowGlobalReach);
            }

            return this;
        }

        /// <summary>
        /// Bandwidth of the circuit. Should be Mbps for service providers or Gbps for ExpressRoute ports. Usage: INT {Mbps,Gbps}.
        /// </summary>
        public AzureNetworkExpressRouteUpdateTask Bandwidth(string bandwidth = null)
        {
            WithArguments("--bandwidth");
            if (!string.IsNullOrEmpty(bandwidth))
            {
                 WithArguments(bandwidth);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of an ExpressRoute port.
        /// </summary>
        public AzureNetworkExpressRouteUpdateTask ExpressRoutePort(string expressRoutePort = null)
        {
            WithArguments("--express-route-port");
            if (!string.IsNullOrEmpty(expressRoutePort))
            {
                 WithArguments(expressRoutePort);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkExpressRouteUpdateTask NoWait(string noWait = null)
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
        public AzureNetworkExpressRouteUpdateTask PeeringLocation(string peeringLocation = null)
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
        public AzureNetworkExpressRouteUpdateTask Provider(string provider = null)
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
        public AzureNetworkExpressRouteUpdateTask SkuFamily(string skuFamily = null)
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
        public AzureNetworkExpressRouteUpdateTask SkuTier(string skuTier = null)
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
        public AzureNetworkExpressRouteUpdateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkExpressRouteUpdateTask Add(string add = null)
        {
            WithArguments("--add");
            if (!string.IsNullOrEmpty(add))
            {
                 WithArguments(add);
            }

            return this;
        }

        /// <summary>
        /// When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.
        /// </summary>
        public AzureNetworkExpressRouteUpdateTask ForceString(string forceString = null)
        {
            WithArguments("--force-string");
            if (!string.IsNullOrEmpty(forceString))
            {
                 WithArguments(forceString);
            }

            return this;
        }

        /// <summary>
        /// Remove a property or an element from a list.  Example: --remove property.list <indexToRemove> OR --remove propertyToRemove.
        /// </summary>
        public AzureNetworkExpressRouteUpdateTask Remove(string remove = null)
        {
            WithArguments("--remove");
            if (!string.IsNullOrEmpty(remove))
            {
                 WithArguments(remove);
            }

            return this;
        }

        /// <summary>
        /// Update an object by specifying a property path and value to set.  Example: --set property1.property2=<value>.
        /// </summary>
        public AzureNetworkExpressRouteUpdateTask Set(string set = null)
        {
            WithArguments("--set");
            if (!string.IsNullOrEmpty(set))
            {
                 WithArguments(set);
            }

            return this;
        }
     }
}
