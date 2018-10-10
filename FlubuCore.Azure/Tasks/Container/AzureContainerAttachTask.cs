
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Container
{
     public partial class AzureContainerAttachTask : ExternalProcessTaskBase<AzureContainerAttachTask>
     {
        
        /// <summary>
        /// Attach local standard output and error streams to a container in a container group.
        /// </summary>
        public AzureContainerAttachTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az container attach");
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
        /// The container to attach to. If omitted, the first container in the container group will be chosen.
        /// </summary>
        public AzureContainerAttachTask ContainerName(string containerName = null)
        {
            WithArguments("--container-name");
            if (!string.IsNullOrEmpty(containerName))
            {
                 WithArguments(containerName);
            }

            return this;
        }
     }
}
