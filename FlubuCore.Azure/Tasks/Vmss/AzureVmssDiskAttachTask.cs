
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssDiskAttachTask : ExternalProcessTaskBase<AzureVmssDiskAttachTask>
     {
        
        /// <summary>
        /// Attach managed data disks to a scale set or its instances.
        /// </summary>
        public AzureVmssDiskAttachTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vmss disk attach");
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

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Disk caching policy.
        /// </summary>
        public AzureVmssDiskAttachTask Caching(string caching = null)
        {
            WithArguments("--caching");
            if (!string.IsNullOrEmpty(caching))
            {
                 WithArguments(caching);
            }

            return this;
        }

        /// <summary>
        /// Existing disk name or ID to attach or detach from VM instances.
        /// </summary>
        public AzureVmssDiskAttachTask Disk(string disk = null)
        {
            WithArguments("--disk");
            if (!string.IsNullOrEmpty(disk))
            {
                 WithArguments(disk);
            }

            return this;
        }

        /// <summary>
        /// Scale set VM instance id.
        /// </summary>
        public AzureVmssDiskAttachTask InstanceId(string instanceId = null)
        {
            WithArguments("--instance-id");
            if (!string.IsNullOrEmpty(instanceId))
            {
                 WithArguments(instanceId);
            }

            return this;
        }

        /// <summary>
        /// 0-based logical unit number (LUN). Max value depends on the Virtual Machine instance size.
        /// </summary>
        public AzureVmssDiskAttachTask Lun(string lun = null)
        {
            WithArguments("--lun");
            if (!string.IsNullOrEmpty(lun))
            {
                 WithArguments(lun);
            }

            return this;
        }

        /// <summary>
        /// Size in GB.
        /// </summary>
        public AzureVmssDiskAttachTask SizeGb(string sizeGb = null)
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
        public AzureVmssDiskAttachTask Sku(string sku = null)
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
