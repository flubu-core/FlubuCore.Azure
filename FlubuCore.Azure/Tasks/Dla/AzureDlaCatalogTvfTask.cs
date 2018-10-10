
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaCatalogTvfTask : ExternalProcessTaskBase<AzureDlaCatalogTvfTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Analytics catalog table valued functions.
        /// </summary>
        public AzureDlaCatalogTvfTask()
        {
            WithArguments("az dla catalog tvf");
        }

        protected override string Description { get; set; }
        
     }
}
