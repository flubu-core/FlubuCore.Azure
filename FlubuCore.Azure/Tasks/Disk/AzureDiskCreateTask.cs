
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Disk
{
     public partial class AzureDiskCreateTask : ExternalProcessTaskBase<AzureDiskCreateTask>
     {
        
        /// <summary>
        /// Create a managed disk.
        /// </summary>
        public AzureDiskCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az disk create");
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
        /// The number of IOPS allowed for this disk. Only settable for UltraSSD disks. One operation can transfer between 4k and 256k bytes.
        /// </summary>
        public AzureDiskCreateTask DiskIopsReadWrite(string diskIopsReadWrite = null)
        {
            WithArguments("--disk-iops-read-write");
            if (!string.IsNullOrEmpty(diskIopsReadWrite))
            {
                 WithArguments(diskIopsReadWrite);
            }

            return this;
        }

        /// <summary>
        /// The bandwidth allowed for this disk. Only settable for UltraSSD disks. MBps means millions of bytes per second with ISO notation of powers of 10.
        /// </summary>
        public AzureDiskCreateTask DiskMbpsReadWrite(string diskMbpsReadWrite = null)
        {
            WithArguments("--disk-mbps-read-write");
            if (!string.IsNullOrEmpty(diskMbpsReadWrite))
            {
                 WithArguments(diskMbpsReadWrite);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureDiskCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureDiskCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Size in GB.
        /// </summary>
        public AzureDiskCreateTask SizeGb(string sizeGb = null)
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
        public AzureDiskCreateTask Sku(string sku = null)
        {
            WithArguments("--sku");
            if (!string.IsNullOrEmpty(sku))
            {
                 WithArguments(sku);
            }

            return this;
        }

        /// <summary>
        /// Source to create the disk/snapshot from, including unmanaged blob uri, managed disk id or name, or snapshot id or name.
        /// </summary>
        public AzureDiskCreateTask Source(string source = null)
        {
            WithArguments("--source");
            if (!string.IsNullOrEmpty(source))
            {
                 WithArguments(source);
            }

            return this;
        }

        /// <summary>
        /// Used when source blob is in a different subscription.
        /// </summary>
        public AzureDiskCreateTask SourceStorageAccountId(string sourceStorageAccountId = null)
        {
            WithArguments("--source-storage-account-id");
            if (!string.IsNullOrEmpty(sourceStorageAccountId))
            {
                 WithArguments(sourceStorageAccountId);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureDiskCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Availability zone into which to provision the resource.
        /// </summary>
        public AzureDiskCreateTask Zone(string zone = null)
        {
            WithArguments("--zone");
            if (!string.IsNullOrEmpty(zone))
            {
                 WithArguments(zone);
            }

            return this;
        }
     }
}
