
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVpnSiteDeleteTask : ExternalProcessTaskBase<AzureNetworkVpnSiteDeleteTask>
     {
        
        /// <summary>
        /// Delete a VPN site configuration.
        /// </summary>
        public AzureNetworkVpnSiteDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network vpn-site delete");
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
