
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkAsgDeleteTask : ExternalProcessTaskBase<AzureNetworkAsgDeleteTask>
     {
        
        /// <summary>
        /// Delete an application security group.
        /// </summary>
        public AzureNetworkAsgDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network asg delete");
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
