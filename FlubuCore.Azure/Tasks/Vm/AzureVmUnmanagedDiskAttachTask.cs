
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmUnmanagedDiskAttachTask : ExternalProcessTaskBase<AzureVmUnmanagedDiskAttachTask>
     {
        
        /// <summary>
        /// Attach an unmanaged persistent disk to a VM.
        /// </summary>
        public AzureVmUnmanagedDiskAttachTask(string resourceGroup = null ,  string vmName = null)
        {
            WithArguments("az vm unmanaged-disk attach");
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
        public AzureVmUnmanagedDiskAttachTask Caching(string caching = null)
        {
            WithArguments("--caching");
            if (!string.IsNullOrEmpty(caching))
            {
                 WithArguments(caching);
            }

            return this;
        }

        /// <summary>
        /// 0-based logical unit number (LUN). Max value depends on the Virtual Machine size.
        /// </summary>
        public AzureVmUnmanagedDiskAttachTask Lun(string lun = null)
        {
            WithArguments("--lun");
            if (!string.IsNullOrEmpty(lun))
            {
                 WithArguments(lun);
            }

            return this;
        }

        /// <summary>
        /// The data disk name(optional when create a new disk).
        /// </summary>
        public AzureVmUnmanagedDiskAttachTask Name(string name = null)
        {
            WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

            return this;
        }

        /// <summary>
        /// Create a new disk.
        /// </summary>
        public AzureVmUnmanagedDiskAttachTask New(string @new = null)
        {
            WithArguments("--new");
            if (!string.IsNullOrEmpty(@new))
            {
                 WithArguments(@new);
            }

            return this;
        }

        public AzureVmUnmanagedDiskAttachTask SizeGb(string sizeGb = null)
        {
            WithArguments("--size-gb");
            if (!string.IsNullOrEmpty(sizeGb))
            {
                 WithArguments(sizeGb);
            }

            return this;
        }

        /// <summary>
        /// Virtual hard disk URI. For example: <a href="https://mystorage.blob.core.windows.net/vhds/d1.vhd">https://mystorage.blob.core.windows.net/vhds/d1.vhd</a>.
        /// </summary>
        public AzureVmUnmanagedDiskAttachTask VhdUri(string vhdUri = null)
        {
            WithArguments("--vhd-uri");
            if (!string.IsNullOrEmpty(vhdUri))
            {
                 WithArguments(vhdUri);
            }

            return this;
        }
     }
}
