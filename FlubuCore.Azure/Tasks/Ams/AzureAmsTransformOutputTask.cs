
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsTransformOutputTask : ExternalProcessTaskBase<AzureAmsTransformOutputTask>
     {
        
        /// <summary>
        /// Manage transform outputs for an Azure Media Services account.
        /// </summary>
        public AzureAmsTransformOutputTask()
        {
            WithArguments("az ams transform output");
        }

        protected override string Description { get; set; }
        
     }
}
