
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVpnConnectionIpsecPolicyTask : ExternalProcessTaskBase<AzureNetworkVpnConnectionIpsecPolicyTask>
     {
        
        /// <summary>
        /// Manage VPN connection IPSec policies.
        /// </summary>
        public AzureNetworkVpnConnectionIpsecPolicyTask()
        {
            WithArguments("az network vpn-connection ipsec-policy");
        }

        protected override string Description { get; set; }
        
     }
}
