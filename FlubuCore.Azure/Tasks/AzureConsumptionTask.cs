
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureConsumptionTask : ExternalProcessTaskBase<AzureConsumptionTask>
     {
        
        /// <summary>
        /// Manage consumption of Azure resources.
        /// </summary>
        public AzureConsumptionTask()
        {
            WithArguments("az consumption");
        }

        protected override string Description { get; set; }
        
     }
}
