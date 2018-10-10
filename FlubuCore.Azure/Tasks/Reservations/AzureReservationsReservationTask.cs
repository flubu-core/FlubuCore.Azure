
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Reservations
{
     public partial class AzureReservationsReservationTask : ExternalProcessTaskBase<AzureReservationsReservationTask>
     {
        
        /// <summary>
        /// Manage reservation entities.
        /// </summary>
        public AzureReservationsReservationTask()
        {
            WithArguments("az reservations reservation");
        }

        protected override string Description { get; set; }
        
     }
}
