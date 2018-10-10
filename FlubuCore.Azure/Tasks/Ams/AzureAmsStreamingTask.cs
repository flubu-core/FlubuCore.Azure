
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsStreamingTask : ExternalProcessTaskBase<AzureAmsStreamingTask>
     {
        
        /// <summary>
        /// Manage streamings for an Azure Media Services account.
        /// </summary>
        public AzureAmsStreamingTask()
        {
            WithArguments("az ams streaming");
        }

        protected override string Description { get; set; }
        
     }
}
