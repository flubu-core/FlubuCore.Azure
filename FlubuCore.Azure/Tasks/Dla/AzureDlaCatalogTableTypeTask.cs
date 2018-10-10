
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaCatalogTableTypeTask : ExternalProcessTaskBase<AzureDlaCatalogTableTypeTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Analytics catalog table types.
        /// </summary>
        public AzureDlaCatalogTableTypeTask()
        {
            WithArguments("az dla catalog table-type");
        }

        protected override string Description { get; set; }
        
     }
}
