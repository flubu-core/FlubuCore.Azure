
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Search
{
     public partial class AzureSearchQueryKeyDeleteTask : ExternalProcessTaskBase<AzureSearchQueryKeyDeleteTask>
     {
        
        /// <summary>
        /// Deletes the specified query key.
        /// </summary>
        public AzureSearchQueryKeyDeleteTask(string keyValue = null ,  string resourceGroup = null ,  string serviceName = null)
        {
            WithArguments("az search query-key delete");
WithArguments("--key-value");
            if (!string.IsNullOrEmpty(keyValue))
            {
                 WithArguments(keyValue);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--service-name");
            if (!string.IsNullOrEmpty(serviceName))
            {
                 WithArguments(serviceName);
            }

        }

        protected override string Description { get; set; }
        
     }
}
