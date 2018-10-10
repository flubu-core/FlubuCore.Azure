
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupJobStopTask : ExternalProcessTaskBase<AzureBackupJobStopTask>
     {
        
        /// <summary>
        /// Suspend or terminate a currently running job.
        /// </summary>
        public AzureBackupJobStopTask(string name = null ,  string resourceGroup = null ,  string vaultName = null)
        {
            WithArguments("az backup job stop");
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

WithArguments("--vault-name");
            if (!string.IsNullOrEmpty(vaultName))
            {
                 WithArguments(vaultName);
            }

        }

        protected override string Description { get; set; }
        
     }
}
