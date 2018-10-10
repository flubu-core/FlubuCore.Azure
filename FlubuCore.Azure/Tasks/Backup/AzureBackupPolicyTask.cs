
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupPolicyTask : ExternalProcessTaskBase<AzureBackupPolicyTask>
     {
        
        /// <summary>
        /// A backup policy defines when you want to take a backup and for how long you would retain each backup copy.
        /// </summary>
        public AzureBackupPolicyTask()
        {
            WithArguments("az backup policy");
        }

        protected override string Description { get; set; }
        
     }
}
