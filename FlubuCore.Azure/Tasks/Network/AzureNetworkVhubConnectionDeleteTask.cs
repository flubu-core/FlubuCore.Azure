
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkVhubConnectionDeleteTask : ExternalProcessTaskBase<AzureNetworkVhubConnectionDeleteTask>
     {
        
        /// <summary>
        /// Delete a virtual hub VNet connection.
        /// </summary>
        public AzureNetworkVhubConnectionDeleteTask(string name = null ,  string resourceGroup = null ,  string vhubName = null)
        {
            WithArguments("az network vhub connection delete");
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

WithArguments("--vhub-name");
            if (!string.IsNullOrEmpty(vhubName))
            {
                 WithArguments(vhubName);
            }

        }

        protected override string Description { get; set; }
        
     }
}
