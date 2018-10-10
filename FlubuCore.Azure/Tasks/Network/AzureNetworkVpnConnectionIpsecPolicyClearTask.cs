
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVpnConnectionIpsecPolicyClearTask : ExternalProcessTaskBase<AzureNetworkVpnConnectionIpsecPolicyClearTask>
     {
        
        /// <summary>
        /// Delete all IPsec policies on a VPN connection.
        /// </summary>
        public AzureNetworkVpnConnectionIpsecPolicyClearTask(string connectionName = null ,  string resourceGroup = null)
        {
            WithArguments("az network vpn-connection ipsec-policy clear");
WithArguments("--connection-name");
            if (!string.IsNullOrEmpty(connectionName))
            {
                 WithArguments(connectionName);
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
        public AzureNetworkVpnConnectionIpsecPolicyClearTask NoWait(string noWait = null)
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
