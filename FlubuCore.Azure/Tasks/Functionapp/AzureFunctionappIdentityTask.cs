
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappIdentityTask : ExternalProcessTaskBase<AzureFunctionappIdentityTask>
     {
        
        /// <summary>
        /// Manage functionapp's managed service identity.
        /// </summary>
        public AzureFunctionappIdentityTask()
        {
            WithArguments("az functionapp identity");
        }

        protected override string Description { get; set; }
        
     }
}
