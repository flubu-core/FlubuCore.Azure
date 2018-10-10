
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVwanDeleteTask : ExternalProcessTaskBase<AzureNetworkVwanDeleteTask>
     {
        
        /// <summary>
        /// Delete a virtual WAN.
        /// </summary>
        public AzureNetworkVwanDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network vwan delete");
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
