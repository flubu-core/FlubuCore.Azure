
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmBootDiagnosticsDisableTask : ExternalProcessTaskBase<AzureVmBootDiagnosticsDisableTask>
     {
        
        /// <summary>
        /// Disable the boot diagnostics on a VM.
        /// </summary>
        public AzureVmBootDiagnosticsDisableTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vm boot-diagnostics disable");
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
