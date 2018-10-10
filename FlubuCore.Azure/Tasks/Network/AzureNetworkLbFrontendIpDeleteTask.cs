
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLbFrontendIpDeleteTask : ExternalProcessTaskBase<AzureNetworkLbFrontendIpDeleteTask>
     {
        
        /// <summary>
        /// Delete a frontend IP address.
        /// </summary>
        public AzureNetworkLbFrontendIpDeleteTask(string lbName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network lb frontend-ip delete");
WithArguments("--lb-name");
            if (!string.IsNullOrEmpty(lbName))
            {
                 WithArguments(lbName);
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
