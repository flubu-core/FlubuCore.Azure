
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureVmTask : ExternalProcessTaskBase<AzureVmTask>
     {
        
        /// <summary>
        /// Manage Linux or Windows virtual machines.
        /// </summary>
        public AzureVmTask()
        {
            WithArguments("az vm");
        }

        protected override string Description { get; set; }
        
     }
}
