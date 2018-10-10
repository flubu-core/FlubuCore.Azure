
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureDiskTask : ExternalProcessTaskBase<AzureDiskTask>
     {
        
        /// <summary>
        /// Manage Azure Managed Disks.
        /// </summary>
        public AzureDiskTask()
        {
            WithArguments("az disk");
        }

        protected override string Description { get; set; }
        
     }
}
