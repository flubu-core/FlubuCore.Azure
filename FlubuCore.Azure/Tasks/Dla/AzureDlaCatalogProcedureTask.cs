
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaCatalogProcedureTask : ExternalProcessTaskBase<AzureDlaCatalogProcedureTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Analytics catalog stored procedures.
        /// </summary>
        public AzureDlaCatalogProcedureTask()
        {
            WithArguments("az dla catalog procedure");
        }

        protected override string Description { get; set; }
        
     }
}
