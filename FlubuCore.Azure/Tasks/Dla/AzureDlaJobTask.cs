
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaJobTask : ExternalProcessTaskBase<AzureDlaJobTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Analytics jobs.
        /// </summary>
        public AzureDlaJobTask()
        {
            WithArguments("az dla job");
        }

        protected override string Description { get; set; }
        
     }
}
