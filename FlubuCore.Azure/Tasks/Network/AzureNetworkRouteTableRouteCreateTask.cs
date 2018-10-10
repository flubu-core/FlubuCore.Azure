
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkRouteTableRouteCreateTask : ExternalProcessTaskBase<AzureNetworkRouteTableRouteCreateTask>
     {
        
        /// <summary>
        /// Create a route in a route table.
        /// </summary>
        public AzureNetworkRouteTableRouteCreateTask(string addressPrefix = null ,  string name = null ,  string nextHopType = null ,  string resourceGroup = null ,  string routeTableName = null)
        {
            WithArguments("az network route-table route create");
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

WithArguments("--next-hop-type");
            if (!string.IsNullOrEmpty(nextHopType))
            {
                 WithArguments(nextHopType);
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
        /// The IP address packets should be forwarded to when using the VirtualAppliance hop type.
        /// </summary>
        public AzureNetworkRouteTableRouteCreateTask NextHopIpAddress(string nextHopIpAddress = null)
        {
            WithArguments("--next-hop-ip-address");
            if (!string.IsNullOrEmpty(nextHopIpAddress))
            {
                 WithArguments(nextHopIpAddress);
            }

            return this;
        }
     }
}
