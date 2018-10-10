
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVnetSubnetCreateTask : ExternalProcessTaskBase<AzureNetworkVnetSubnetCreateTask>
     {
        
        /// <summary>
        /// Create a subnet and associate an existing NSG and route table.
        /// </summary>
        public AzureNetworkVnetSubnetCreateTask(string addressPrefix = null ,  string name = null ,  string resourceGroup = null ,  string vnetName = null)
        {
            WithArguments("az network vnet subnet create");
WithArguments("--address-prefix");
            if (!string.IsNullOrEmpty(addressPrefix))
            {
                 WithArguments(addressPrefix);
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

WithArguments("--vnet-name");
            if (!string.IsNullOrEmpty(vnetName))
            {
                 WithArguments(vnetName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Space-separated list of services to whom the subnet should be delegated. (e.g. Microsoft.Sql/servers).
        /// </summary>
        public AzureNetworkVnetSubnetCreateTask Delegations(string delegations = null)
        {
            WithArguments("--delegations");
            if (!string.IsNullOrEmpty(delegations))
            {
                 WithArguments(delegations);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of a network security group (NSG).
        /// </summary>
        public AzureNetworkVnetSubnetCreateTask NetworkSecurityGroup(string networkSecurityGroup = null)
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
        public AzureNetworkVnetSubnetCreateTask RouteTable(string routeTable = null)
        {
            WithArguments("--route-table");
            if (!string.IsNullOrEmpty(routeTable))
            {
                 WithArguments(routeTable);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of names or IDs of service endpoint policies to apply.
        /// </summary>
        public AzureNetworkVnetSubnetCreateTask ServiceEndpointPolicy(string serviceEndpointPolicy = null)
        {
            WithArguments("--service-endpoint-policy");
            if (!string.IsNullOrEmpty(serviceEndpointPolicy))
            {
                 WithArguments(serviceEndpointPolicy);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of services allowed private access to this subnet.
        /// </summary>
        public AzureNetworkVnetSubnetCreateTask ServiceEndpoints(string serviceEndpoints = null)
        {
            WithArguments("--service-endpoints");
            if (!string.IsNullOrEmpty(serviceEndpoints))
            {
                 WithArguments(serviceEndpoints);
            }

            return this;
        }
     }
}
