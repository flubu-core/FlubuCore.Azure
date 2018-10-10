
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVhubDeleteTask : ExternalProcessTaskBase<AzureNetworkVhubDeleteTask>
     {
        
        /// <summary>
        /// Delete a virtual hub.
        /// </summary>
        public AzureNetworkVhubDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network vhub delete");
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
