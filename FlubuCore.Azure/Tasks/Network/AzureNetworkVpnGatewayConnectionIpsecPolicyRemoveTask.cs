
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVpnGatewayConnectionIpsecPolicyRemoveTask : ExternalProcessTaskBase<AzureNetworkVpnGatewayConnectionIpsecPolicyRemoveTask>
     {
        
        /// <summary>
        /// Remove an IPSec policy from a VPN gateway connection.
        /// </summary>
        public AzureNetworkVpnGatewayConnectionIpsecPolicyRemoveTask(string connectionName = null ,  string gatewayName = null ,  string index = null ,  string resourceGroup = null)
        {
            WithArguments("az network vpn-gateway connection ipsec-policy remove");
WithArguments("--connection-name");
            if (!string.IsNullOrEmpty(connectionName))
            {
                 WithArguments(connectionName);
            }

WithArguments("--gateway-name");
            if (!string.IsNullOrEmpty(gatewayName))
            {
                 WithArguments(gatewayName);
            }

WithArguments("--index");
            if (!string.IsNullOrEmpty(index))
            {
                 WithArguments(index);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkVpnGatewayConnectionIpsecPolicyRemoveTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }
     }
}
