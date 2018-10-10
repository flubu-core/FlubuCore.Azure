
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cdn
{
     public partial class AzureCdnProfileTask : ExternalProcessTaskBase<AzureCdnProfileTask>
     {
        
        /// <summary>
        /// Manage CDN profiles to define an edge network.
        /// </summary>
        public AzureCdnProfileTask()
        {
            WithArguments("az cdn profile");
        }

        protected override string Description { get; set; }
        
     }
}
