
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmExtensionTask : ExternalProcessTaskBase<AzureVmExtensionTask>
     {
        
        /// <summary>
        /// Manage extensions on VMs.
        /// </summary>
        public AzureVmExtensionTask()
        {
            WithArguments("az vm extension");
        }

        protected override string Description { get; set; }
        
     }
}
