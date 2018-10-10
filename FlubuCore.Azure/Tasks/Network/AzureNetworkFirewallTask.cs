
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFirewallTask : ExternalProcessTaskBase<AzureNetworkFirewallTask>
     {
        
        /// <summary>
        /// Manage and configure Azure Firewalls.
        /// </summary>
        public AzureNetworkFirewallTask()
        {
            WithArguments("az network firewall");
        }

        protected override string Description { get; set; }
        
     }
}
