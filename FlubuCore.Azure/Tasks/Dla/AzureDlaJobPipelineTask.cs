
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dla
{
     public partial class AzureDlaJobPipelineTask : ExternalProcessTaskBase<AzureDlaJobPipelineTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage Data Lake Analytics job pipelines.
        /// </summary>
        public AzureDlaJobPipelineTask()
        {
            WithArguments("az dla job pipeline");
        }

        protected override string Description { get; set; }
        
     }
}
