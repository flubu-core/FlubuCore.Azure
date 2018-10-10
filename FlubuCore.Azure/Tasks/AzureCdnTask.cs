
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureCdnTask : ExternalProcessTaskBase<AzureCdnTask>
     {
        
        /// <summary>
        /// Manage Azure Content Delivery Networks (CDNs).
        /// </summary>
        public AzureCdnTask()
        {
            WithArguments("az cdn");
        }

        protected override string Description { get; set; }
        
     }
}
