
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaCatalogExternalDataSourceTask : ExternalProcessTaskBase<AzureDlaCatalogExternalDataSourceTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Analytics catalog external data sources.
        /// </summary>
        public AzureDlaCatalogExternalDataSourceTask()
        {
            WithArguments("az dla catalog external-data-source");
        }

        protected override string Description { get; set; }
        
     }
}
