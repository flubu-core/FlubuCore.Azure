
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkFirewallDeleteTask : ExternalProcessTaskBase<AzureNetworkFirewallDeleteTask>
     {
        
        /// <summary>
        /// Delete an Azure Firewall.
        /// </summary>
        public AzureNetworkFirewallDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network firewall delete");
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
