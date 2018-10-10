
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaCatalogTask : ExternalProcessTaskBase<AzureDlaCatalogTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Analytics catalogs.
        /// </summary>
        public AzureDlaCatalogTask()
        {
            WithArguments("az dla catalog");
        }

        protected override string Description { get; set; }
        
     }
}
