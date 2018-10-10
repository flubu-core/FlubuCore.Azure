
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsStreamingPolicyCreateTask : ExternalProcessTaskBase<AzureAmsStreamingPolicyCreateTask>
     {
        
        /// <summary>
        /// Create a streaming policy.
        /// </summary>
        public AzureAmsStreamingPolicyCreateTask(string accountName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az ams streaming policy create");
WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
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

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The default content key policy name used by the streaming locator.
        /// </summary>
        public AzureAmsStreamingPolicyCreateTask ContentPolicyName(string contentPolicyName = null)
        {
            WithArguments("--content-policy-name");
            if (!string.IsNullOrEmpty(contentPolicyName))
            {
                 WithArguments(contentPolicyName);
            }

            return this;
        }

        /// <summary>
        /// Enable Dash protocol.
        /// </summary>
        public AzureAmsStreamingPolicyCreateTask Dash(string dash = null)
        {
            WithArguments("--dash");
            if (!string.IsNullOrEmpty(dash))
            {
                 WithArguments(dash);
            }

            return this;
        }

        /// <summary>
        /// Enable Download protocol.
        /// </summary>
        public AzureAmsStreamingPolicyCreateTask Download(string download = null)
        {
            WithArguments("--download");
            if (!string.IsNullOrEmpty(download))
            {
                 WithArguments(download);
            }

            return this;
        }

        /// <summary>
        /// Enable HLS protocol.
        /// </summary>
        public AzureAmsStreamingPolicyCreateTask Hls(string hls = null)
        {
            WithArguments("--hls");
            if (!string.IsNullOrEmpty(hls))
            {
                 WithArguments(hls);
            }

            return this;
        }

        /// <summary>
        /// Enable SmoothStreaming protocol.
        /// </summary>
        public AzureAmsStreamingPolicyCreateTask SmoothStreaming(string smoothStreaming = null)
        {
            WithArguments("--smooth-streaming");
            if (!string.IsNullOrEmpty(smoothStreaming))
            {
                 WithArguments(smoothStreaming);
            }

            return this;
        }
     }
}
