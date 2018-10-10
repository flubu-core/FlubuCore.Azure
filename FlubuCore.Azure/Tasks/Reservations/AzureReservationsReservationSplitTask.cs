
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Reservations
{
     public partial class AzureReservationsReservationSplitTask : ExternalProcessTaskBase<AzureReservationsReservationSplitTask>
     {
        
        /// <summary>
        /// Split a reservation.
        /// </summary>
        public AzureReservationsReservationSplitTask(string quantity1 = null ,  string quantity2 = null ,  string reservationId = null ,  string reservationOrderId = null)
        {
            WithArguments("az reservations reservation split");
WithArguments("--quantity-1");
            if (!string.IsNullOrEmpty(quantity1))
            {
                 WithArguments(quantity1);
            }

WithArguments("--quantity-2");
            if (!string.IsNullOrEmpty(quantity2))
            {
                 WithArguments(quantity2);
            }

WithArguments("--reservation-id");
            if (!string.IsNullOrEmpty(reservationId))
            {
                 WithArguments(reservationId);
            }

WithArguments("--reservation-order-id");
            if (!string.IsNullOrEmpty(reservationOrderId))
            {
                 WithArguments(reservationOrderId);
            }

        }

        protected override string Description { get; set; }
        
     }
}
