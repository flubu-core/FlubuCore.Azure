
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cdn
{
     public partial class AzureCdnEdgeNodeTask : ExternalProcessTaskBase<AzureCdnEdgeNodeTask>
     {
        
        /// <summary>
        /// View all available CDN edge nodes.
        /// </summary>
        public AzureCdnEdgeNodeTask()
        {
            WithArguments("az cdn edge-node");
        }

        protected override string Description { get; set; }
        
     }
}
