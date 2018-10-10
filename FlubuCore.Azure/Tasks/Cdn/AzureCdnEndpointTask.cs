
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cdn
{
     public partial class AzureCdnEndpointTask : ExternalProcessTaskBase<AzureCdnEndpointTask>
     {
        
        /// <summary>
        /// Manage CDN endpoints.
        /// </summary>
        public AzureCdnEndpointTask()
        {
            WithArguments("az cdn endpoint");
        }

        protected override string Description { get; set; }
        
     }
}
