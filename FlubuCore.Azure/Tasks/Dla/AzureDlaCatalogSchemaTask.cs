
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaCatalogSchemaTask : ExternalProcessTaskBase<AzureDlaCatalogSchemaTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Analytics catalog schemas.
        /// </summary>
        public AzureDlaCatalogSchemaTask()
        {
            WithArguments("az dla catalog schema");
        }

        protected override string Description { get; set; }
        
     }
}
