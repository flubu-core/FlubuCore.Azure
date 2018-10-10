
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkRouteTableRouteUpdateTask : ExternalProcessTaskBase<AzureNetworkRouteTableRouteUpdateTask>
     {
        
        /// <summary>
        /// Update a route in a route table.
        /// </summary>
        public AzureNetworkRouteTableRouteUpdateTask(string name = null ,  string resourceGroup = null ,  string routeTableName = null)
        {
            WithArguments("az network route-table route update");
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
        
        /// <summary>
        /// The destination CIDR to which the route applies.
        /// </summary>
        public AzureNetworkRouteTableRouteUpdateTask AddressPrefix(string addressPrefix = null)
        {
            WithArguments("--address-prefix");
            if (!string.IsNullOrEmpty(addressPrefix))
            {
                 WithArguments(addressPrefix);
            }

            return this;
        }

        /// <summary>
        /// The IP address packets should be forwarded to when using the VirtualAppliance hop type.
        /// </summary>
        public AzureNetworkRouteTableRouteUpdateTask NextHopIpAddress(string nextHopIpAddress = null)
        {
            WithArguments("--next-hop-ip-address");
            if (!string.IsNullOrEmpty(nextHopIpAddress))
            {
                 WithArguments(nextHopIpAddress);
            }

            return this;
        }

        /// <summary>
        /// The type of Azure hop the packet should be sent to.
        /// </summary>
        public AzureNetworkRouteTableRouteUpdateTask NextHopType(string nextHopType = null)
        {
            WithArguments("--next-hop-type");
            if (!string.IsNullOrEmpty(nextHopType))
            {
                 WithArguments(nextHopType);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkRouteTableRouteUpdateTask Add(string add = null)
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
        public AzureNetworkRouteTableRouteUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkRouteTableRouteUpdateTask Remove(string remove = null)
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
        public AzureNetworkRouteTableRouteUpdateTask Set(string set = null)
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
