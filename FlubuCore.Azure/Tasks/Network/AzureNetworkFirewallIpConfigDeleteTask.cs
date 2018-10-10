
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFirewallIpConfigDeleteTask : ExternalProcessTaskBase<AzureNetworkFirewallIpConfigDeleteTask>
     {
        
        /// <summary>
        /// Delete an Azure Firewall IP configuration.
        /// </summary>
        public AzureNetworkFirewallIpConfigDeleteTask(string firewallName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network firewall ip-config delete");
WithArguments("--firewall-name");
            if (!string.IsNullOrEmpty(firewallName))
            {
                 WithArguments(firewallName);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
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
