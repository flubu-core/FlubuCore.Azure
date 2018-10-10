
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmBootDiagnosticsGetBootLogTask : ExternalProcessTaskBase<AzureVmBootDiagnosticsGetBootLogTask>
     {
        
        /// <summary>
        /// Get the boot diagnostics log from a VM.
        /// </summary>
        public AzureVmBootDiagnosticsGetBootLogTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vm boot-diagnostics get-boot-log");
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
