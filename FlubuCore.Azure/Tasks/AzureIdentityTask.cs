
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureIdentityTask : ExternalProcessTaskBase<AzureIdentityTask>
     {
        
        /// <summary>
        /// Managed Service Identities.
        /// </summary>
        public AzureIdentityTask()
        {
            WithArguments("az identity");
        }

        protected override string Description { get; set; }
        
     }
}
