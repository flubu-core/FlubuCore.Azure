
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureDmsTask : ExternalProcessTaskBase<AzureDmsTask>
     {
        
        /// <summary>
        /// Manage Azure Data Migration Service (DMS) instances.
        /// </summary>
        public AzureDmsTask()
        {
            WithArguments("az dms");
        }

        protected override string Description { get; set; }
        
     }
}
