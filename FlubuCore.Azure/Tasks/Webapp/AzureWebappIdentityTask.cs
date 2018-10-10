
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappIdentityTask : ExternalProcessTaskBase<AzureWebappIdentityTask>
     {
        
        /// <summary>
        /// Manage webapp's managed service identity.
        /// </summary>
        public AzureWebappIdentityTask()
        {
            WithArguments("az webapp identity");
        }

        protected override string Description { get; set; }
        
     }
}
