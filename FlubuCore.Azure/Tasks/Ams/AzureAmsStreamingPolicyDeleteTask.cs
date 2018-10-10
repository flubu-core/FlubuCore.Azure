
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsStreamingPolicyDeleteTask : ExternalProcessTaskBase<AzureAmsStreamingPolicyDeleteTask>
     {
        
        /// <summary>
        /// Delete a Streaming Policy.
        /// </summary>
        public AzureAmsStreamingPolicyDeleteTask(string accountName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az ams streaming policy delete");
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
        
     }
}
