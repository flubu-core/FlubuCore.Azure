
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmCaptureTask : ExternalProcessTaskBase<AzureVmCaptureTask>
     {
        
        /// <summary>
        /// Capture information for a stopped VM.
        /// </summary>
        public AzureVmCaptureTask(string name = null ,  string resourceGroup = null ,  string vhdNamePrefix = null)
        {
            WithArguments("az vm capture");
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

WithArguments("--vhd-name-prefix");
            if (!string.IsNullOrEmpty(vhdNamePrefix))
            {
                 WithArguments(vhdNamePrefix);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Overwrite the existing disk file.
        /// </summary>
        public AzureVmCaptureTask Overwrite(string overwrite = null)
        {
            WithArguments("--overwrite");
            if (!string.IsNullOrEmpty(overwrite))
            {
                 WithArguments(overwrite);
            }

            return this;
        }

        /// <summary>
        /// The storage account container name in which to save the disks.
        /// </summary>
        public AzureVmCaptureTask StorageContainer(string storageContainer = null)
        {
            WithArguments("--storage-container");
            if (!string.IsNullOrEmpty(storageContainer))
            {
                 WithArguments(storageContainer);
            }

            return this;
        }
     }
}
