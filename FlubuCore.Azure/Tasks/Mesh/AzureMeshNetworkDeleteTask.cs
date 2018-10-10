
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mesh
{
     public partial class AzureMeshNetworkDeleteTask : ExternalProcessTaskBase<AzureMeshNetworkDeleteTask>
     {
        
        /// <summary>
        /// Delete a network.
        /// </summary>
        public AzureMeshNetworkDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az mesh network delete");
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
        
        /// <summary>
        /// Do not prompt for confirmation.
        /// </summary>
        public AzureMeshNetworkDeleteTask Yes(string yes = null)
        {
            WithArguments("--yes");
            if (!string.IsNullOrEmpty(yes))
            {
                 WithArguments(yes);
            }

            return this;
        }
     }
}
