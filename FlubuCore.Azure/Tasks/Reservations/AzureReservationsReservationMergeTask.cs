
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Reservations
{
     public partial class AzureReservationsReservationMergeTask : ExternalProcessTaskBase<AzureReservationsReservationMergeTask>
     {
        
        /// <summary>
        /// Merge two reservations.
        /// </summary>
        public AzureReservationsReservationMergeTask(string reservationId1 = null ,  string reservationId2 = null ,  string reservationOrderId = null)
        {
            WithArguments("az reservations reservation merge");
WithArguments("--reservation-id-1");
            if (!string.IsNullOrEmpty(reservationId1))
            {
                 WithArguments(reservationId1);
            }

WithArguments("--reservation-id-2");
            if (!string.IsNullOrEmpty(reservationId2))
            {
                 WithArguments(reservationId2);
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
