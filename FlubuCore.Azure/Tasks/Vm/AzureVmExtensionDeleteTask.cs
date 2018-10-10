
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmExtensionDeleteTask : ExternalProcessTaskBase<AzureVmExtensionDeleteTask>
     {
        
        /// <summary>
        /// Remove an extension attached to a VM.
        /// </summary>
        public AzureVmExtensionDeleteTask(string name = null ,  string resourceGroup = null ,  string vmName = null)
        {
            WithArguments("az vm extension delete");
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

WithArguments("--vm-name");
            if (!string.IsNullOrEmpty(vmName))
            {
                 WithArguments(vmName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureVmExtensionDeleteTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }
     }
}
