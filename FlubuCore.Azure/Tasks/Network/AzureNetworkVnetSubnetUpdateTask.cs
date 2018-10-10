
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVnetSubnetUpdateTask : ExternalProcessTaskBase<AzureNetworkVnetSubnetUpdateTask>
     {
        
        /// <summary>
        /// Update a subnet.
        /// </summary>
        public AzureNetworkVnetSubnetUpdateTask(string name = null ,  string resourceGroup = null ,  string vnetName = null)
        {
            WithArguments("az network vnet subnet update");
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

WithArguments("--vnet-name");
            if (!string.IsNullOrEmpty(vnetName))
            {
                 WithArguments(vnetName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The address prefix in CIDR format.
        /// </summary>
        public AzureNetworkVnetSubnetUpdateTask AddressPrefix(string addressPrefix = null)
        {
            WithArguments("--address-prefix");
            if (!string.IsNullOrEmpty(addressPrefix))
            {
                 WithArguments(addressPrefix);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of services to whom the subnet should be delegated. (e.g. Microsoft.Sql/servers).
        /// </summary>
        public AzureNetworkVnetSubnetUpdateTask Delegations(string delegations = null)
        {
            WithArguments("--delegations");
            if (!string.IsNullOrEmpty(delegations))
            {
                 WithArguments(delegations);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of a network security group (NSG). Use empty string "" to detach it.
        /// </summary>
        public AzureNetworkVnetSubnetUpdateTask NetworkSecurityGroup(string networkSecurityGroup = null)
        {
            WithArguments("--network-security-group");
            if (!string.IsNullOrEmpty(networkSecurityGroup))
            {
                 WithArguments(networkSecurityGroup);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of a route table to associate with the subnet.
        /// </summary>
        public AzureNetworkVnetSubnetUpdateTask RouteTable(string routeTable = null)
        {
            WithArguments("--route-table");
            if (!string.IsNullOrEmpty(routeTable))
            {
                 WithArguments(routeTable);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of services allowed private access to this subnet.
        /// </summary>
        public AzureNetworkVnetSubnetUpdateTask ServiceEndpoints(string serviceEndpoints = null)
        {
            WithArguments("--service-endpoints");
            if (!string.IsNullOrEmpty(serviceEndpoints))
            {
                 WithArguments(serviceEndpoints);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkVnetSubnetUpdateTask Add(string add = null)
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
        public AzureNetworkVnetSubnetUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkVnetSubnetUpdateTask Remove(string remove = null)
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
        public AzureNetworkVnetSubnetUpdateTask Set(string set = null)
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
