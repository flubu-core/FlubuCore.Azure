
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVnetPeeringCreateTask : ExternalProcessTaskBase<AzureNetworkVnetPeeringCreateTask>
     {
        
        /// <summary>
        /// Create a virtual network peering connection.
        /// </summary>
        public AzureNetworkVnetPeeringCreateTask(string name = null ,  string remoteVnetId = null ,  string resourceGroup = null ,  string vnetName = null)
        {
            WithArguments("az network vnet peering create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--remote-vnet-id");
            if (!string.IsNullOrEmpty(remoteVnetId))
            {
                 WithArguments(remoteVnetId);
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
        /// Allows forwarded traffic from the VMs in the remote VNet.
        /// </summary>
        public AzureNetworkVnetPeeringCreateTask AllowForwardedTraffic(string allowForwardedTraffic = null)
        {
            WithArguments("--allow-forwarded-traffic");
            if (!string.IsNullOrEmpty(allowForwardedTraffic))
            {
                 WithArguments(allowForwardedTraffic);
            }

            return this;
        }

        /// <summary>
        /// Allows gateway link to be used in the remote VNet.
        /// </summary>
        public AzureNetworkVnetPeeringCreateTask AllowGatewayTransit(string allowGatewayTransit = null)
        {
            WithArguments("--allow-gateway-transit");
            if (!string.IsNullOrEmpty(allowGatewayTransit))
            {
                 WithArguments(allowGatewayTransit);
            }

            return this;
        }

        /// <summary>
        /// Allows VMs in the remote VNet to access all VMs in the local VNet.
        /// </summary>
        public AzureNetworkVnetPeeringCreateTask AllowVnetAccess(string allowVnetAccess = null)
        {
            WithArguments("--allow-vnet-access");
            if (!string.IsNullOrEmpty(allowVnetAccess))
            {
                 WithArguments(allowVnetAccess);
            }

            return this;
        }

        /// <summary>
        /// Allows VNet to use the remote VNet's gateway. Remote VNet gateway must have --allow-gateway-transit enabled for remote peering. Only 1 peering can have this flag enabled. Cannot be set if the VNet already has a gateway.
        /// </summary>
        public AzureNetworkVnetPeeringCreateTask UseRemoteGateways(string useRemoteGateways = null)
        {
            WithArguments("--use-remote-gateways");
            if (!string.IsNullOrEmpty(useRemoteGateways))
            {
                 WithArguments(useRemoteGateways);
            }

            return this;
        }
     }
}
