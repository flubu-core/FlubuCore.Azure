
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaCatalogDatabaseTask : ExternalProcessTaskBase<AzureDlaCatalogDatabaseTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Analytics catalog databases.
        /// </summary>
        public AzureDlaCatalogDatabaseTask()
        {
            WithArguments("az dla catalog database");
        }

        protected override string Description { get; set; }
        
     }
}
