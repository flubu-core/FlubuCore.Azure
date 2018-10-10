
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cdn
{
     public partial class AzureCdnOriginTask : ExternalProcessTaskBase<AzureCdnOriginTask>
     {
        
        /// <summary>
        /// List or show existing origins related to CDN endpoints.
        /// </summary>
        public AzureCdnOriginTask()
        {
            WithArguments("az cdn origin");
        }

        protected override string Description { get; set; }
        
     }
}
