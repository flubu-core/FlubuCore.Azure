
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaCatalogAssemblyTask : ExternalProcessTaskBase<AzureDlaCatalogAssemblyTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Analytics catalog assemblies.
        /// </summary>
        public AzureDlaCatalogAssemblyTask()
        {
            WithArguments("az dla catalog assembly");
        }

        protected override string Description { get; set; }
        
     }
}
