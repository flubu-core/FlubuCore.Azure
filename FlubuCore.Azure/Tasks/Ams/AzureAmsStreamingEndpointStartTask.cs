
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsStreamingEndpointStartTask : ExternalProcessTaskBase<AzureAmsStreamingEndpointStartTask>
     {
        
        /// <summary>
        /// Start a streaming endpoint.
        /// </summary>
        public AzureAmsStreamingEndpointStartTask(string accountName = null ,  string resourceGroup = null ,  string streamingEndpointName = null)
        {
            WithArguments("az ams streaming endpoint start");
WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--streaming-endpoint-name");
            if (!string.IsNullOrEmpty(streamingEndpointName))
            {
                 WithArguments(streamingEndpointName);
            }

        }

        protected override string Description { get; set; }
        
     }
}
