
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVpnGatewayConnectionIpsecPolicyAddTask : ExternalProcessTaskBase<AzureNetworkVpnGatewayConnectionIpsecPolicyAddTask>
     {
        
        /// <summary>
        /// Add an IPSec policy to a VPN gateway connection.
        /// </summary>
        public AzureNetworkVpnGatewayConnectionIpsecPolicyAddTask(string connectionName = null ,  string gatewayName = null ,  string resourceGroup = null ,  string dhGroup = null ,  string ikeEncryption = null ,  string ikeIntegrity = null ,  string ipsecEncryption = null ,  string ipsecIntegrity = null ,  string pfsGroup = null ,  string saDataSize = null ,  string saLifetime = null)
        {
            WithArguments("az network vpn-gateway connection ipsec-policy add");
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

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--dh-group");
            if (!string.IsNullOrEmpty(dhGroup))
            {
                 WithArguments(dhGroup);
            }

WithArguments("--ike-encryption");
            if (!string.IsNullOrEmpty(ikeEncryption))
            {
                 WithArguments(ikeEncryption);
            }

WithArguments("--ike-integrity");
            if (!string.IsNullOrEmpty(ikeIntegrity))
            {
                 WithArguments(ikeIntegrity);
            }

WithArguments("--ipsec-encryption");
            if (!string.IsNullOrEmpty(ipsecEncryption))
            {
                 WithArguments(ipsecEncryption);
            }

WithArguments("--ipsec-integrity");
            if (!string.IsNullOrEmpty(ipsecIntegrity))
            {
                 WithArguments(ipsecIntegrity);
            }

WithArguments("--pfs-group");
            if (!string.IsNullOrEmpty(pfsGroup))
            {
                 WithArguments(pfsGroup);
            }

WithArguments("--sa-data-size");
            if (!string.IsNullOrEmpty(saDataSize))
            {
                 WithArguments(saDataSize);
            }

WithArguments("--sa-lifetime");
            if (!string.IsNullOrEmpty(saLifetime))
            {
                 WithArguments(saLifetime);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkVpnGatewayConnectionIpsecPolicyAddTask NoWait(string noWait = null)
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
