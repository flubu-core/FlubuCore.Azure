
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmUnmanagedDiskTask : ExternalProcessTaskBase<AzureVmUnmanagedDiskTask>
     {
        
        /// <summary>
        /// Manage the unmanaged data disks attached to a VM.
        /// </summary>
        public AzureVmUnmanagedDiskTask()
        {
            WithArguments("az vm unmanaged-disk");
        }

        protected override string Description { get; set; }
        
     }
}
