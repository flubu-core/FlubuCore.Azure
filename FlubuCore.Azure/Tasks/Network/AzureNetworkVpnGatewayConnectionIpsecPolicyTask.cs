
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVpnGatewayConnectionIpsecPolicyTask : ExternalProcessTaskBase<AzureNetworkVpnGatewayConnectionIpsecPolicyTask>
     {
        
        /// <summary>
        /// Manage VPN gateway connection IPSec policies.
        /// </summary>
        public AzureNetworkVpnGatewayConnectionIpsecPolicyTask()
        {
            WithArguments("az network vpn-gateway connection ipsec-policy");
        }

        protected override string Description { get; set; }
        
     }
}
