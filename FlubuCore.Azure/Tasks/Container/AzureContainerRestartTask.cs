
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Container
{
     public partial class AzureContainerRestartTask : ExternalProcessTaskBase<AzureContainerRestartTask>
     {
        
        /// <summary>
        /// Restarts all containers in a container group.
        /// </summary>
        public AzureContainerRestartTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az container restart");
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
