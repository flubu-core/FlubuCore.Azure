
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Reservations
{
     public partial class AzureReservationsReservationOrderTask : ExternalProcessTaskBase<AzureReservationsReservationOrderTask>
     {
        
        /// <summary>
        /// Manage reservation order, which is container for reservations.
        /// </summary>
        public AzureReservationsReservationOrderTask()
        {
            WithArguments("az reservations reservation-order");
        }

        protected override string Description { get; set; }
        
     }
}
