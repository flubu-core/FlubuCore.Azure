
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Consumption
{
     public partial class AzureConsumptionReservationSummaryTask : ExternalProcessTaskBase<AzureConsumptionReservationSummaryTask>
     {
        
        /// <summary>
        /// List reservation summaries.
        /// </summary>
        public AzureConsumptionReservationSummaryTask()
        {
            WithArguments("az consumption reservation summary");
        }

        protected override string Description { get; set; }
        
     }
}
