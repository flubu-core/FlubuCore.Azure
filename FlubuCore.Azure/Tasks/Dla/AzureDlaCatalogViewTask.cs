
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaCatalogViewTask : ExternalProcessTaskBase<AzureDlaCatalogViewTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Analytics catalog views.
        /// </summary>
        public AzureDlaCatalogViewTask()
        {
            WithArguments("az dla catalog view");
        }

        protected override string Description { get; set; }
        
     }
}
