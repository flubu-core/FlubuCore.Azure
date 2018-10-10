
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmUnmanagedDiskDetachTask : ExternalProcessTaskBase<AzureVmUnmanagedDiskDetachTask>
     {
        
        /// <summary>
        /// Detach an unmanaged disk from a VM.
        /// </summary>
        public AzureVmUnmanagedDiskDetachTask(string name = null ,  string resourceGroup = null ,  string vmName = null)
        {
            WithArguments("az vm unmanaged-disk detach");
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

WithArguments("--vm-name");
            if (!string.IsNullOrEmpty(vmName))
            {
                 WithArguments(vmName);
            }

        }

        protected override string Description { get; set; }
        
     }
}
