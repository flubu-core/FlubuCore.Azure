
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFirewallIpConfigTask : ExternalProcessTaskBase<AzureNetworkFirewallIpConfigTask>
     {
        
        /// <summary>
        /// Manage and configure Azure Firewall IP configurations.
        /// </summary>
        public AzureNetworkFirewallIpConfigTask()
        {
            WithArguments("az network firewall ip-config");
        }

        protected override string Description { get; set; }
        
     }
}
