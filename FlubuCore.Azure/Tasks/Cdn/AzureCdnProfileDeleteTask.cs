
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cdn
{
     public partial class AzureCdnProfileDeleteTask : ExternalProcessTaskBase<AzureCdnProfileDeleteTask>
     {
        
        /// <summary>
        /// Delete a CDN profile.
        /// </summary>
        public AzureCdnProfileDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az cdn profile delete");
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
