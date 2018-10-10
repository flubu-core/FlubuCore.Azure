
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Consumption
{
     public partial class AzureConsumptionReservationDetailTask : ExternalProcessTaskBase<AzureConsumptionReservationDetailTask>
     {
        
        /// <summary>
        /// List reservation details.
        /// </summary>
        public AzureConsumptionReservationDetailTask()
        {
            WithArguments("az consumption reservation detail");
        }

        protected override string Description { get; set; }
        
     }
}
