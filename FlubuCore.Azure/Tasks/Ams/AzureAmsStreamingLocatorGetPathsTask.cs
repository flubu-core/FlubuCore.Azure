
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsStreamingLocatorGetPathsTask : ExternalProcessTaskBase<AzureAmsStreamingLocatorGetPathsTask>
     {
        
        /// <summary>
        /// List paths supported by a streaming locator.
        /// </summary>
        public AzureAmsStreamingLocatorGetPathsTask(string accountName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az ams streaming locator get-paths");
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
