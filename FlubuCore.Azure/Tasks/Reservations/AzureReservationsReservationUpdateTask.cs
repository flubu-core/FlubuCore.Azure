
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Reservations
{
     public partial class AzureReservationsReservationUpdateTask : ExternalProcessTaskBase<AzureReservationsReservationUpdateTask>
     {
        
        /// <summary>
        /// Updates the applied scopes of the reservation.
        /// </summary>
        public AzureReservationsReservationUpdateTask(string appliedScopeType = null ,  string reservationId = null ,  string reservationOrderId = null)
        {
            WithArguments("az reservations reservation update");
WithArguments("--applied-scope-type");
            if (!string.IsNullOrEmpty(appliedScopeType))
            {
                 WithArguments(appliedScopeType);
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
        
        /// <summary>
        /// Subscription that the benefit will be applied. Do not specify if AppliedScopeType is Shared.
        /// </summary>
        public AzureReservationsReservationUpdateTask AppliedScopes(string appliedScopes = null)
        {
            WithArguments("--applied-scopes");
            if (!string.IsNullOrEmpty(appliedScopes))
            {
                 WithArguments(appliedScopes);
            }

            return this;
        }

        /// <summary>
        /// Type of the Instance Flexibility to update the reservation with.
        /// </summary>
        public AzureReservationsReservationUpdateTask InstanceFlexibility(string instanceFlexibility = null)
        {
            WithArguments("--instance-flexibility");
            if (!string.IsNullOrEmpty(instanceFlexibility))
            {
                 WithArguments(instanceFlexibility);
            }

            return this;
        }
     }
}
