
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkLbDeleteTask : ExternalProcessTaskBase<AzureNetworkLbDeleteTask>
     {
        
        /// <summary>
        /// Delete a load balancer.
        /// </summary>
        public AzureNetworkLbDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network lb delete");
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
