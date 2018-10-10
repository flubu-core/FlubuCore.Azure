
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssDiagnosticsTask : ExternalProcessTaskBase<AzureVmssDiagnosticsTask>
     {
        
        /// <summary>
        /// Configure the Azure Virtual Machine Scale Set diagnostics extension.
        /// </summary>
        public AzureVmssDiagnosticsTask()
        {
            WithArguments("az vmss diagnostics");
        }

        protected override string Description { get; set; }
        
     }
}
