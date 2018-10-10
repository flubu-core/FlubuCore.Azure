
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVpnConnectionSharedKeyTask : ExternalProcessTaskBase<AzureNetworkVpnConnectionSharedKeyTask>
     {
        
        /// <summary>
        /// Manage VPN shared keys.
        /// </summary>
        public AzureNetworkVpnConnectionSharedKeyTask()
        {
            WithArguments("az network vpn-connection shared-key");
        }

        protected override string Description { get; set; }
        
     }
}
