
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Consumption
{
     public partial class AzureConsumptionReservationTask : ExternalProcessTaskBase<AzureConsumptionReservationTask>
     {
        
        /// <summary>
        /// Manage reservations for Azure resources.
        /// </summary>
        public AzureConsumptionReservationTask()
        {
            WithArguments("az consumption reservation");
        }

        protected override string Description { get; set; }
        
     }
}
