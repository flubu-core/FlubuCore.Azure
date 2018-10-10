
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Lab
{
     public partial class AzureLabGetTask : ExternalProcessTaskBase<AzureLabGetTask>
     {
        
        /// <summary>
        /// Get lab.
        /// </summary>
        public AzureLabGetTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az lab get");
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
        /// Specify the $expand query. Example: 'properties($select=defaultStorageAccount)'.
        /// </summary>
        public AzureLabGetTask Expand(string expand = null)
        {
            WithArguments("--expand");
            if (!string.IsNullOrEmpty(expand))
            {
                 WithArguments(expand);
            }

            return this;
        }
     }
}
