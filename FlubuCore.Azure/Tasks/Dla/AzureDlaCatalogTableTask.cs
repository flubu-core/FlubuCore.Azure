
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaCatalogTableTask : ExternalProcessTaskBase<AzureDlaCatalogTableTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Analytics catalog tables.
        /// </summary>
        public AzureDlaCatalogTableTask()
        {
            WithArguments("az dla catalog table");
        }

        protected override string Description { get; set; }
        
     }
}
