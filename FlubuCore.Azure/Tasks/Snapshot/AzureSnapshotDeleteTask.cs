
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Snapshot
{
     public partial class AzureSnapshotDeleteTask : ExternalProcessTaskBase<AzureSnapshotDeleteTask>
     {
        
        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        public AzureSnapshotDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az snapshot delete");
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
        
     }
}
