
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cdn
{
     public partial class AzureCdnUsageTask : ExternalProcessTaskBase<AzureCdnUsageTask>
     {
        
        /// <summary>
        /// Check the quota and actual usage of the CDN profiles under the given subscription.
        /// </summary>
        public AzureCdnUsageTask()
        {
            WithArguments("az cdn usage");
        }

        protected override string Description { get; set; }
        
     }
}
