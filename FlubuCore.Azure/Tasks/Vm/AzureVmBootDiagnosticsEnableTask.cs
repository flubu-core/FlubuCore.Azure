
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmBootDiagnosticsEnableTask : ExternalProcessTaskBase<AzureVmBootDiagnosticsEnableTask>
     {
        
        /// <summary>
        /// Enable the boot diagnostics on a VM.
        /// </summary>
        public AzureVmBootDiagnosticsEnableTask(string name = null ,  string resourceGroup = null ,  string storage = null)
        {
            WithArguments("az vm boot-diagnostics enable");
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

WithArguments("--storage");
            if (!string.IsNullOrEmpty(storage))
            {
                 WithArguments(storage);
            }

        }

        protected override string Description { get; set; }
        
     }
}
