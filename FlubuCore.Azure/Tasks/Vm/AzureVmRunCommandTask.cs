
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmRunCommandTask : ExternalProcessTaskBase<AzureVmRunCommandTask>
     {
        
        /// <summary>
        /// Manage run commands on a Virtual Machine.
        /// </summary>
        public AzureVmRunCommandTask()
        {
            WithArguments("az vm run-command");
        }

        protected override string Description { get; set; }
        
     }
}
