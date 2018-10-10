
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureMonitorTask : ExternalProcessTaskBase<AzureMonitorTask>
     {
        
        /// <summary>
        /// Manage the Azure Monitor Service.
        /// </summary>
        public AzureMonitorTask()
        {
            WithArguments("az monitor");
        }

        protected override string Description { get; set; }
        
     }
}
