
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Container
{
     public partial class AzureContainerExecTask : ExternalProcessTaskBase<AzureContainerExecTask>
     {
        
        /// <summary>
        /// Execute a command from within a running container of a container group.
        /// </summary>
        public AzureContainerExecTask(string execCommand = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az container exec");
WithArguments("--exec-command");
            if (!string.IsNullOrEmpty(execCommand))
            {
                 WithArguments(execCommand);
            }

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
        /// The container name where to execute the command. Can be ommitted for container groups with only one container.
        /// </summary>
        public AzureContainerExecTask ContainerName(string containerName = null)
        {
            WithArguments("--container-name");
            if (!string.IsNullOrEmpty(containerName))
            {
                 WithArguments(containerName);
            }

            return this;
        }

        /// <summary>
        /// The col size for the command output.
        /// </summary>
        public AzureContainerExecTask TerminalColSize(string terminalColSize = null)
        {
            WithArguments("--terminal-col-size");
            if (!string.IsNullOrEmpty(terminalColSize))
            {
                 WithArguments(terminalColSize);
            }

            return this;
        }

        /// <summary>
        /// The row size for the command output.
        /// </summary>
        public AzureContainerExecTask TerminalRowSize(string terminalRowSize = null)
        {
            WithArguments("--terminal-row-size");
            if (!string.IsNullOrEmpty(terminalRowSize))
            {
                 WithArguments(terminalRowSize);
            }

            return this;
        }
     }
}
