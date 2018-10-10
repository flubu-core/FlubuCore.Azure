
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupVaultCreateTask : ExternalProcessTaskBase<AzureBackupVaultCreateTask>
     {
        
        /// <summary>
        /// Create a new Recovery Services vault.
        /// </summary>
        public AzureBackupVaultCreateTask(string location = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az backup vault create");
WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
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
