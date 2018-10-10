
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Container
{
     public partial class AzureContainerLogsTask : ExternalProcessTaskBase<AzureContainerLogsTask>
     {
        
        /// <summary>
        /// Examine the logs for a container in a container group.
        /// </summary>
        public AzureContainerLogsTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az container logs");
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
        /// The container name to tail the logs. If omitted, the first container in the container group will be chosen.
        /// </summary>
        public AzureContainerLogsTask ContainerName(string containerName = null)
        {
            WithArguments("--container-name");
            if (!string.IsNullOrEmpty(containerName))
            {
                 WithArguments(containerName);
            }

            return this;
        }

        /// <summary>
        /// Indicate to stream the tailing logs.
        /// </summary>
        public AzureContainerLogsTask Follow(string follow = null)
        {
            WithArguments("--follow");
            if (!string.IsNullOrEmpty(follow))
            {
                 WithArguments(follow);
            }

            return this;
        }
     }
}
