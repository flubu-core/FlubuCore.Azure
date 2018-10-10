
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVpnConnectionIpsecPolicyAddTask : ExternalProcessTaskBase<AzureNetworkVpnConnectionIpsecPolicyAddTask>
     {
        
        /// <summary>
        /// Add a VPN connection IPSec policy.
        /// </summary>
        public AzureNetworkVpnConnectionIpsecPolicyAddTask(string connectionName = null ,  string dhGroup = null ,  string ikeEncryption = null ,  string ikeIntegrity = null ,  string ipsecEncryption = null ,  string ipsecIntegrity = null ,  string pfsGroup = null ,  string resourceGroup = null ,  string saLifetime = null ,  string saMaxSize = null)
        {
            WithArguments("az network vpn-connection ipsec-policy add");
WithArguments("--connection-name");
            if (!string.IsNullOrEmpty(connectionName))
            {
                 WithArguments(connectionName);
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

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--sa-lifetime");
            if (!string.IsNullOrEmpty(saLifetime))
            {
                 WithArguments(saLifetime);
            }

WithArguments("--sa-max-size");
            if (!string.IsNullOrEmpty(saMaxSize))
            {
                 WithArguments(saMaxSize);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkVpnConnectionIpsecPolicyAddTask NoWait(string noWait = null)
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
