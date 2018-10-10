
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsStreamingPolicyTask : ExternalProcessTaskBase<AzureAmsStreamingPolicyTask>
     {
        
        /// <summary>
        /// Manage streaming policies for an Azure Media Services account.
        /// </summary>
        public AzureAmsStreamingPolicyTask()
        {
            WithArguments("az ams streaming policy");
        }

        protected override string Description { get; set; }
        
     }
}
