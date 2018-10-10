
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmDiskAttachTask : ExternalProcessTaskBase<AzureVmDiskAttachTask>
     {
        
        /// <summary>
        /// Attach a managed persistent disk to a VM.
        /// </summary>
        public AzureVmDiskAttachTask(string disk = null ,  string resourceGroup = null ,  string vmName = null)
        {
            WithArguments("az vm disk attach");
WithArguments("--disk");
            if (!string.IsNullOrEmpty(disk))
            {
                 WithArguments(disk);
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
        
        /// <summary>
        /// Disk caching policy.
        /// </summary>
        public AzureVmDiskAttachTask Caching(string caching = null)
        {
            WithArguments("--caching");
            if (!string.IsNullOrEmpty(caching))
            {
                 WithArguments(caching);
            }

            return this;
        }

        /// <summary>
        /// Enable write accelerator.
        /// </summary>
        public AzureVmDiskAttachTask EnableWriteAccelerator(string enableWriteAccelerator = null)
        {
            WithArguments("--enable-write-accelerator");
            if (!string.IsNullOrEmpty(enableWriteAccelerator))
            {
                 WithArguments(enableWriteAccelerator);
            }

            return this;
        }

        /// <summary>
        /// 0-based logical unit number (LUN). Max value depends on the Virtual Machine size.
        /// </summary>
        public AzureVmDiskAttachTask Lun(string lun = null)
        {
            WithArguments("--lun");
            if (!string.IsNullOrEmpty(lun))
            {
                 WithArguments(lun);
            }

            return this;
        }

        /// <summary>
        /// Create a new disk.
        /// </summary>
        public AzureVmDiskAttachTask New(string @new = null)
        {
            WithArguments("--new");
            if (!string.IsNullOrEmpty(@new))
            {
                 WithArguments(@new);
            }

            return this;
        }

        /// <summary>
        /// Size in GB.
        /// </summary>
        public AzureVmDiskAttachTask SizeGb(string sizeGb = null)
        {
            WithArguments("--size-gb");
            if (!string.IsNullOrEmpty(sizeGb))
            {
                 WithArguments(sizeGb);
            }

            return this;
        }

        /// <summary>
        /// Underlying storage SKU.
        /// </summary>
        public AzureVmDiskAttachTask Sku(string sku = null)
        {
            WithArguments("--sku");
            if (!string.IsNullOrEmpty(sku))
            {
                 WithArguments(sku);
            }

            return this;
        }
     }
}
