
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dms
{
     public partial class AzureDmsProjectTaskTask : ExternalProcessTaskBase<AzureDmsProjectTaskTask>
     {
        
        /// <summary>
        /// Manage Tasks for a Data Migration Service instance's Project.
        /// </summary>
        public AzureDmsProjectTaskTask()
        {
            WithArguments("az dms project task");
        }

        protected override string Description { get; set; }
        
     }
}
