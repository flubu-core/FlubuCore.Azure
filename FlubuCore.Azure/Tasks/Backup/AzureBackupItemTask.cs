
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupItemTask : ExternalProcessTaskBase<AzureBackupItemTask>
     {
        
        /// <summary>
        /// An item which is already protected or backed up to an Azure Recovery services vault with an associated policy.
        /// </summary>
        public AzureBackupItemTask()
        {
            WithArguments("az backup item");
        }

        protected override string Description { get; set; }
        
     }
}
