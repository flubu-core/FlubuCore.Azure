
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVpnGatewayConnectionCreateTask : ExternalProcessTaskBase<AzureNetworkVpnGatewayConnectionCreateTask>
     {
        
        /// <summary>
        /// Create a VPN gateway connection.
        /// </summary>
        public AzureNetworkVpnGatewayConnectionCreateTask(string gatewayName = null ,  string name = null ,  string remoteVpnSite = null ,  string resourceGroup = null)
        {
            WithArguments("az network vpn-gateway connection create");
WithArguments("--gateway-name");
            if (!string.IsNullOrEmpty(gatewayName))
            {
                 WithArguments(gatewayName);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--remote-vpn-site");
            if (!string.IsNullOrEmpty(remoteVpnSite))
            {
                 WithArguments(remoteVpnSite);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Expected bandwidth in Mbps.
        /// </summary>
        public AzureNetworkVpnGatewayConnectionCreateTask ConnectionBandwidth(string connectionBandwidth = null)
        {
            WithArguments("--connection-bandwidth");
            if (!string.IsNullOrEmpty(connectionBandwidth))
            {
                 WithArguments(connectionBandwidth);
            }

            return this;
        }

        /// <summary>
        /// Enable BGP.
        /// </summary>
        public AzureNetworkVpnGatewayConnectionCreateTask EnableBgp(string enableBgp = null)
        {
            WithArguments("--enable-bgp");
            if (!string.IsNullOrEmpty(enableBgp))
            {
                 WithArguments(enableBgp);
            }

            return this;
        }

        /// <summary>
        /// Enable internet security.
        /// </summary>
        public AzureNetworkVpnGatewayConnectionCreateTask InternetSecurity(string internetSecurity = null)
        {
            WithArguments("--internet-security");
            if (!string.IsNullOrEmpty(internetSecurity))
            {
                 WithArguments(internetSecurity);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkVpnGatewayConnectionCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Connection protocol.
        /// </summary>
        public AzureNetworkVpnGatewayConnectionCreateTask ProtocolType(string protocolType = null)
        {
            WithArguments("--protocol-type");
            if (!string.IsNullOrEmpty(protocolType))
            {
                 WithArguments(protocolType);
            }

            return this;
        }

        /// <summary>
        /// Enable rate limiting.
        /// </summary>
        public AzureNetworkVpnGatewayConnectionCreateTask RateLimiting(string rateLimiting = null)
        {
            WithArguments("--rate-limiting");
            if (!string.IsNullOrEmpty(rateLimiting))
            {
                 WithArguments(rateLimiting);
            }

            return this;
        }

        /// <summary>
        /// Routing weight.
        /// </summary>
        public AzureNetworkVpnGatewayConnectionCreateTask RoutingWeight(string routingWeight = null)
        {
            WithArguments("--routing-weight");
            if (!string.IsNullOrEmpty(routingWeight))
            {
                 WithArguments(routingWeight);
            }

            return this;
        }

        /// <summary>
        /// Shared key.
        /// </summary>
        public AzureNetworkVpnGatewayConnectionCreateTask SharedKey(string sharedKey = null)
        {
            WithArguments("--shared-key");
            if (!string.IsNullOrEmpty(sharedKey))
            {
                 WithArguments(sharedKey);
            }

            return this;
        }
     }
}
