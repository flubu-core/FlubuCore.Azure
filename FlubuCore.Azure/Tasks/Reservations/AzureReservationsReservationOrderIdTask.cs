
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Reservations
{
     public partial class AzureReservationsReservationOrderIdTask : ExternalProcessTaskBase<AzureReservationsReservationOrderIdTask>
     {
        
        /// <summary>
        /// See reservation order ids that are applied to subscription.
        /// </summary>
        public AzureReservationsReservationOrderIdTask()
        {
            WithArguments("az reservations reservation-order-id");
        }

        protected override string Description { get; set; }
        
     }
}
