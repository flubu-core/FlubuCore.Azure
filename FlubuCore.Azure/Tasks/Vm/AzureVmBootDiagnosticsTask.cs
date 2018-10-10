
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmBootDiagnosticsTask : ExternalProcessTaskBase<AzureVmBootDiagnosticsTask>
     {
        
        /// <summary>
        /// Troubleshoot the startup of an Azure Virtual Machine.
        /// </summary>
        public AzureVmBootDiagnosticsTask()
        {
            WithArguments("az vm boot-diagnostics");
        }

        protected override string Description { get; set; }
        
     }
}
