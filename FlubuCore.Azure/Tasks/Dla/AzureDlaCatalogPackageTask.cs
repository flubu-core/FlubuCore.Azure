
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaCatalogPackageTask : ExternalProcessTaskBase<AzureDlaCatalogPackageTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Analytics catalog packages.
        /// </summary>
        public AzureDlaCatalogPackageTask()
        {
            WithArguments("az dla catalog package");
        }

        protected override string Description { get; set; }
        
     }
}
