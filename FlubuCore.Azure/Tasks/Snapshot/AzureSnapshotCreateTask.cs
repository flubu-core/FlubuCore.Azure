
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Snapshot
{
     public partial class AzureSnapshotCreateTask : ExternalProcessTaskBase<AzureSnapshotCreateTask>
     {
        
        /// <summary>
        /// Create a snapshot.
        /// </summary>
        public AzureSnapshotCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az snapshot create");
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
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureSnapshotCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Size in GB.
        /// </summary>
        public AzureSnapshotCreateTask SizeGb(string sizeGb = null)
        {
            WithArguments("--size-gb");
            if (!string.IsNullOrEmpty(sizeGb))
            {
                 WithArguments(sizeGb);
            }

            return this;
        }

        public AzureSnapshotCreateTask Sku(string sku = null)
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
        public AzureSnapshotCreateTask Source(string source = null)
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
        public AzureSnapshotCreateTask SourceStorageAccountId(string sourceStorageAccountId = null)
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
        public AzureSnapshotCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }
     }
}
