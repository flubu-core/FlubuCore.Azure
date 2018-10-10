
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsTransformTask : ExternalProcessTaskBase<AzureAmsTransformTask>
     {
        
        /// <summary>
        /// Manage transforms for an Azure Media Services account.
        /// </summary>
        public AzureAmsTransformTask()
        {
            WithArguments("az ams transform");
        }

        protected override string Description { get; set; }
        
     }
}
