
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Snapshot
{
     public partial class AzureSnapshotRevokeAccessTask : ExternalProcessTaskBase<AzureSnapshotRevokeAccessTask>
     {
        
        /// <summary>
        /// Revoke read access to a snapshot.
        /// </summary>
        public AzureSnapshotRevokeAccessTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az snapshot revoke-access");
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
