
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVpnConnectionTask : ExternalProcessTaskBase<AzureNetworkVpnConnectionTask>
     {
        
        /// <summary>
        /// Manage VPN connections.
        /// </summary>
        public AzureNetworkVpnConnectionTask()
        {
            WithArguments("az network vpn-connection");
        }

        protected override string Description { get; set; }
        
     }
}
