
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsStreamingLocatorCreateTask : ExternalProcessTaskBase<AzureAmsStreamingLocatorCreateTask>
     {
        
        /// <summary>
        /// Create a streaming locator.
        /// </summary>
        public AzureAmsStreamingLocatorCreateTask(string accountName = null ,  string assetName = null ,  string name = null ,  string resourceGroup = null ,  string streamingPolicyName = null)
        {
            WithArguments("az ams streaming locator create");
WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

WithArguments("--asset-name");
            if (!string.IsNullOrEmpty(assetName))
            {
                 WithArguments(assetName);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--streaming-policy-name");
            if (!string.IsNullOrEmpty(streamingPolicyName))
            {
                 WithArguments(streamingPolicyName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The default content key policy name used by the streaming locator.
        /// </summary>
        public AzureAmsStreamingLocatorCreateTask ContentPolicyName(string contentPolicyName = null)
        {
            WithArguments("--content-policy-name");
            if (!string.IsNullOrEmpty(contentPolicyName))
            {
                 WithArguments(contentPolicyName);
            }

            return this;
        }

        /// <summary>
        /// End time (Y-m-d'T'H:M:S'Z') of the streaming locator.
        /// </summary>
        public AzureAmsStreamingLocatorCreateTask EndTime(string endTime = null)
        {
            WithArguments("--end-time");
            if (!string.IsNullOrEmpty(endTime))
            {
                 WithArguments(endTime);
            }

            return this;
        }

        /// <summary>
        /// Start time (Y-m-d'T'H:M:S'Z') of the streaming locator.
        /// </summary>
        public AzureAmsStreamingLocatorCreateTask StartTime(string startTime = null)
        {
            WithArguments("--start-time");
            if (!string.IsNullOrEmpty(startTime))
            {
                 WithArguments(startTime);
            }

            return this;
        }
     }
}
