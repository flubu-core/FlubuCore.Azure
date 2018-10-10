
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVpnConnectionSharedKeyResetTask : ExternalProcessTaskBase<AzureNetworkVpnConnectionSharedKeyResetTask>
     {
        
        /// <summary>
        /// Reset a VPN connection shared key.
        /// </summary>
        public AzureNetworkVpnConnectionSharedKeyResetTask(string connectionName = null ,  string keyLength = null ,  string resourceGroup = null)
        {
            WithArguments("az network vpn-connection shared-key reset");
WithArguments("--connection-name");
            if (!string.IsNullOrEmpty(connectionName))
            {
                 WithArguments(connectionName);
            }

WithArguments("--key-length");
            if (!string.IsNullOrEmpty(keyLength))
            {
                 WithArguments(keyLength);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
     }
}
