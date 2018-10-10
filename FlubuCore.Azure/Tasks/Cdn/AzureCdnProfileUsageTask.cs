
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cdn
{
     public partial class AzureCdnProfileUsageTask : ExternalProcessTaskBase<AzureCdnProfileUsageTask>
     {
        
        /// <summary>
        /// Checks the quota and actual usage of endpoints under the given CDN profile.
        /// </summary>
        public AzureCdnProfileUsageTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az cdn profile usage");
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
