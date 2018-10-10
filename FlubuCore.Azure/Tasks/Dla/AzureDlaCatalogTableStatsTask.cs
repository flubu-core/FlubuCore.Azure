
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaCatalogTableStatsTask : ExternalProcessTaskBase<AzureDlaCatalogTableStatsTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Analytics catalog table statistics.
        /// </summary>
        public AzureDlaCatalogTableStatsTask()
        {
            WithArguments("az dla catalog table-stats");
        }

        protected override string Description { get; set; }
        
     }
}
