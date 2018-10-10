
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureReservationsTask : ExternalProcessTaskBase<AzureReservationsTask>
     {
        
        /// <summary>
        /// Manage Azure Reservations.
        /// </summary>
        public AzureReservationsTask()
        {
            WithArguments("az reservations");
        }

        protected override string Description { get; set; }
        
     }
}
