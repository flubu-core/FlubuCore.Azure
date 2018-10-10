
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Consumption
{
     public partial class AzureConsumptionPricesheetTask : ExternalProcessTaskBase<AzureConsumptionPricesheetTask>
     {
        
        /// <summary>
        /// Inspect the price sheet of an Azure subscription within a billing period.
        /// </summary>
        public AzureConsumptionPricesheetTask()
        {
            WithArguments("az consumption pricesheet");
        }

        protected override string Description { get; set; }
        
     }
}
