
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVpnSiteTask : ExternalProcessTaskBase<AzureNetworkVpnSiteTask>
     {
        
        /// <summary>
        /// Manage VPN site configurations.
        /// </summary>
        public AzureNetworkVpnSiteTask()
        {
            WithArguments("az network vpn-site");
        }

        protected override string Description { get; set; }
        
     }
}
