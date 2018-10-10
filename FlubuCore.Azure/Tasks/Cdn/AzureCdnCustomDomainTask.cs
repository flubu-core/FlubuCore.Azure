
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cdn
{
     public partial class AzureCdnCustomDomainTask : ExternalProcessTaskBase<AzureCdnCustomDomainTask>
     {
        
        /// <summary>
        /// Manage Azure CDN Custom Domains to provide custom host names for endpoints.
        /// </summary>
        public AzureCdnCustomDomainTask()
        {
            WithArguments("az cdn custom-domain");
        }

        protected override string Description { get; set; }
        
     }
}
