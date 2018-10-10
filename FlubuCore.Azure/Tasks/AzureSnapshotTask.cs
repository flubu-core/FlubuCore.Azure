
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureSnapshotTask : ExternalProcessTaskBase<AzureSnapshotTask>
     {
        
        /// <summary>
        /// Manage point-in-time copies of managed disks, native blobs, or other snapshots.
        /// </summary>
        public AzureSnapshotTask()
        {
            WithArguments("az snapshot");
        }

        protected override string Description { get; set; }
        
     }
}
