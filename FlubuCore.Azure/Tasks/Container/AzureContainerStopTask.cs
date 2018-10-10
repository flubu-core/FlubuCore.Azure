
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Container
{
     public partial class AzureContainerStopTask : ExternalProcessTaskBase<AzureContainerStopTask>
     {
        
        /// <summary>
        /// Stops all containers in a container group.
        /// </summary>
        public AzureContainerStopTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az container stop");
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
