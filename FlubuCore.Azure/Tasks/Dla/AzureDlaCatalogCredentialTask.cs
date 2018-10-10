
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaCatalogCredentialTask : ExternalProcessTaskBase<AzureDlaCatalogCredentialTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Analytics catalog credentials.
        /// </summary>
        public AzureDlaCatalogCredentialTask()
        {
            WithArguments("az dla catalog credential");
        }

        protected override string Description { get; set; }
        
     }
}
