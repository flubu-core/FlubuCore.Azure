
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Consumption
{
     public partial class AzureConsumptionUsageTask : ExternalProcessTaskBase<AzureConsumptionUsageTask>
     {
        
        /// <summary>
        /// Inspect the usage of Azure resources.
        /// </summary>
        public AzureConsumptionUsageTask()
        {
            WithArguments("az consumption usage");
        }

        protected override string Description { get; set; }
        
     }
}
