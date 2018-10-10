
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Backup
{
     public partial class AzureBackupContainerTask : ExternalProcessTaskBase<AzureBackupContainerTask>
     {
        
        /// <summary>
        /// Resource which houses items or applications to be protected.
        /// </summary>
        public AzureBackupContainerTask()
        {
            WithArguments("az backup container");
        }

        protected override string Description { get; set; }
        
     }
}
