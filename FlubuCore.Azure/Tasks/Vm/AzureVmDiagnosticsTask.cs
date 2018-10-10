
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmDiagnosticsTask : ExternalProcessTaskBase<AzureVmDiagnosticsTask>
     {
        
        /// <summary>
        /// Configure the Azure Virtual Machine diagnostics extension.
        /// </summary>
        public AzureVmDiagnosticsTask()
        {
            WithArguments("az vm diagnostics");
        }

        protected override string Description { get; set; }
        
     }
}
