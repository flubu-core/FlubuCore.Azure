
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsStreamingEndpointTask : ExternalProcessTaskBase<AzureAmsStreamingEndpointTask>
     {
        
        /// <summary>
        /// Manage streaming endpoints for an Azure Media Service account.
        /// </summary>
        public AzureAmsStreamingEndpointTask()
        {
            WithArguments("az ams streaming endpoint");
        }

        protected override string Description { get; set; }
        
     }
}
