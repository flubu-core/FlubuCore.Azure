
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Search
{
     public partial class AzureSearchQueryKeyCreateTask : ExternalProcessTaskBase<AzureSearchQueryKeyCreateTask>
     {
        
        /// <summary>
        /// Generates a new query key for the specified Search service.
        /// </summary>
        public AzureSearchQueryKeyCreateTask(string name = null ,  string resourceGroup = null ,  string serviceName = null)
        {
            WithArguments("az search query-key create");
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

WithArguments("--service-name");
            if (!string.IsNullOrEmpty(serviceName))
            {
                 WithArguments(serviceName);
            }

        }

        protected override string Description { get; set; }
        
     }
}
