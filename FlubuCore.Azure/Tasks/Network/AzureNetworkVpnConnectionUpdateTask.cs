
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVpnConnectionUpdateTask : ExternalProcessTaskBase<AzureNetworkVpnConnectionUpdateTask>
     {
        
        /// <summary>
        /// Update a VPN connection.
        /// </summary>
        public AzureNetworkVpnConnectionUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network vpn-connection update");
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
        /// Enable BGP (Border Gateway Protocol).
        /// </summary>
        public AzureNetworkVpnConnectionUpdateTask EnableBgp(string enableBgp = null)
        {
            WithArguments("--enable-bgp");
            if (!string.IsNullOrEmpty(enableBgp))
            {
                 WithArguments(enableBgp);
            }

            return this;
        }

        /// <summary>
        /// Connection routing weight.
        /// </summary>
        public AzureNetworkVpnConnectionUpdateTask RoutingWeight(string routingWeight = null)
        {
            WithArguments("--routing-weight");
            if (!string.IsNullOrEmpty(routingWeight))
            {
                 WithArguments(routingWeight);
            }

            return this;
        }

        /// <summary>
        /// Shared IPSec key.
        /// </summary>
        public AzureNetworkVpnConnectionUpdateTask SharedKey(string sharedKey = null)
        {
            WithArguments("--shared-key");
            if (!string.IsNullOrEmpty(sharedKey))
            {
                 WithArguments(sharedKey);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureNetworkVpnConnectionUpdateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Enable policy-based traffic selectors.
        /// </summary>
        public AzureNetworkVpnConnectionUpdateTask UsePolicyBasedTrafficSelectors(string usePolicyBasedTrafficSelectors = null)
        {
            WithArguments("--use-policy-based-traffic-selectors");
            if (!string.IsNullOrEmpty(usePolicyBasedTrafficSelectors))
            {
                 WithArguments(usePolicyBasedTrafficSelectors);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkVpnConnectionUpdateTask Add(string add = null)
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
        public AzureNetworkVpnConnectionUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkVpnConnectionUpdateTask Remove(string remove = null)
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
        public AzureNetworkVpnConnectionUpdateTask Set(string set = null)
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
