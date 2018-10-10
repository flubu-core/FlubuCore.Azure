
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Snapshot
{
     public partial class AzureSnapshotGrantAccessTask : ExternalProcessTaskBase<AzureSnapshotGrantAccessTask>
     {
        
        /// <summary>
        /// Grant read access to a snapshot.
        /// </summary>
        public AzureSnapshotGrantAccessTask(string durationInSeconds = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az snapshot grant-access");
WithArguments("--duration-in-seconds");
            if (!string.IsNullOrEmpty(durationInSeconds))
            {
                 WithArguments(durationInSeconds);
            }

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
