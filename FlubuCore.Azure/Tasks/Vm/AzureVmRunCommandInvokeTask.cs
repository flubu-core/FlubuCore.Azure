
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmRunCommandInvokeTask : ExternalProcessTaskBase<AzureVmRunCommandInvokeTask>
     {
        
        /// <summary>
        /// Execute a specific run command on a vm.
        /// </summary>
        public AzureVmRunCommandInvokeTask(string commandId = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vm run-command invoke");
WithArguments("--command-id");
            if (!string.IsNullOrEmpty(commandId))
            {
                 WithArguments(commandId);
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
        /// Space-separated parameters in the format of '[name=]value'.
        /// </summary>
        public AzureVmRunCommandInvokeTask Parameters(string parameters = null)
        {
            WithArguments("--parameters");
            if (!string.IsNullOrEmpty(parameters))
            {
                 WithArguments(parameters);
            }

            return this;
        }

        /// <summary>
        /// Script lines separated by whites spaces. Use @{file} to load from a file.
        /// </summary>
        public AzureVmRunCommandInvokeTask Scripts(string scripts = null)
        {
            WithArguments("--scripts");
            if (!string.IsNullOrEmpty(scripts))
            {
                 WithArguments(scripts);
            }

            return this;
        }
     }
}
