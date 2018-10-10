
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureSfTask : ExternalProcessTaskBase<AzureSfTask>
     {
        
        /// <summary>
        /// Manage and administer Azure Service Fabric clusters.
        /// </summary>
        public AzureSfTask()
        {
            WithArguments("az sf");
        }

        protected override string Description { get; set; }
        
     }
}
