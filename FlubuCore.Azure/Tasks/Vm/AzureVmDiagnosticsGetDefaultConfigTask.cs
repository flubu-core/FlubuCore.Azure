
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmDiagnosticsGetDefaultConfigTask : ExternalProcessTaskBase<AzureVmDiagnosticsGetDefaultConfigTask>
     {
        
        /// <summary>
        /// Get the default configuration settings for a VM.
        /// </summary>
        public AzureVmDiagnosticsGetDefaultConfigTask()
        {
            WithArguments("az vm diagnostics get-default-config");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// For Windows VMs.
        /// </summary>
        public AzureVmDiagnosticsGetDefaultConfigTask IsWindowsOs(string isWindowsOs = null)
        {
            WithArguments("--is-windows-os");
            if (!string.IsNullOrEmpty(isWindowsOs))
            {
                 WithArguments(isWindowsOs);
            }

            return this;
        }
     }
}
