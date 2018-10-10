
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureDlaTask : ExternalProcessTaskBase<AzureDlaTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Analytics accounts, jobs, and catalogs.
        /// </summary>
        public AzureDlaTask()
        {
            WithArguments("az dla");
        }

        protected override string Description { get; set; }
        
     }
}
