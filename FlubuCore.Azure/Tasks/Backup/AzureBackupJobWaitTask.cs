
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupJobWaitTask : ExternalProcessTaskBase<AzureBackupJobWaitTask>
     {
        
        /// <summary>
        /// Wait until either the job completes or the specified timeout value is reached.
        /// </summary>
        public AzureBackupJobWaitTask(string name = null ,  string resourceGroup = null ,  string vaultName = null)
        {
            WithArguments("az backup job wait");
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
        
        /// <summary>
        /// Maximum time, in seconds, to wait before aborting.
        /// </summary>
        public AzureBackupJobWaitTask Timeout(string timeout = null)
        {
            WithArguments("--timeout");
            if (!string.IsNullOrEmpty(timeout))
            {
                 WithArguments(timeout);
            }

            return this;
        }
     }
}
