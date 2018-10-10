
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dms
{
     public partial class AzureDmsProjectTask : ExternalProcessTaskBase<AzureDmsProjectTask>
     {
        
        /// <summary>
        /// Manage Projects for an instance of the Data Migration Service.
        /// </summary>
        public AzureDmsProjectTask()
        {
            WithArguments("az dms project");
        }

        protected override string Description { get; set; }
        
     }
}
