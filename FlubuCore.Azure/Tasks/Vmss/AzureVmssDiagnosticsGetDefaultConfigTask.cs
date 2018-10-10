
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssDiagnosticsGetDefaultConfigTask : ExternalProcessTaskBase<AzureVmssDiagnosticsGetDefaultConfigTask>
     {
        
        /// <summary>
        /// Show the default config file which defines data to be collected.
        /// </summary>
        public AzureVmssDiagnosticsGetDefaultConfigTask()
        {
            WithArguments("az vmss diagnostics get-default-config");
        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// For Windows VMs.
        /// </summary>
        public AzureVmssDiagnosticsGetDefaultConfigTask IsWindowsOs(string isWindowsOs = null)
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
