
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmDiskTask : ExternalProcessTaskBase<AzureVmDiskTask>
     {
        
        /// <summary>
        /// Manage the managed data disks attached to a VM.
        /// </summary>
        public AzureVmDiskTask()
        {
            WithArguments("az vm disk");
        }

        protected override string Description { get; set; }
        
     }
}
