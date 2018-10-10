
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupJobTask : ExternalProcessTaskBase<AzureBackupJobTask>
     {
        
        /// <summary>
        /// Entity which contains details of the job.
        /// </summary>
        public AzureBackupJobTask()
        {
            WithArguments("az backup job");
        }

        protected override string Description { get; set; }
        
     }
}
