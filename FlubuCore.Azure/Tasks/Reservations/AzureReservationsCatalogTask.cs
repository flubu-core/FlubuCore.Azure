
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Reservations
{
     public partial class AzureReservationsCatalogTask : ExternalProcessTaskBase<AzureReservationsCatalogTask>
     {
        
        /// <summary>
        /// See catalog of available reservations.
        /// </summary>
        public AzureReservationsCatalogTask()
        {
            WithArguments("az reservations catalog");
        }

        protected override string Description { get; set; }
        
     }
}
