
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmAemSetTask : ExternalProcessTaskBase<AzureVmAemSetTask>
     {
        
        /// <summary>
        /// Configure Azure Enhanced Monitoring Extension.
        /// </summary>
        public AzureVmAemSetTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vm aem set");
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
        /// Skip enabling analytics on storage accounts.
        /// </summary>
        public AzureVmAemSetTask SkipStorageAnalytics(string skipStorageAnalytics = null)
        {
            WithArguments("--skip-storage-analytics");
            if (!string.IsNullOrEmpty(skipStorageAnalytics))
            {
                 WithArguments(skipStorageAnalytics);
            }

            return this;
        }
     }
}
