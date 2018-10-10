
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Policy
{
     public partial class AzurePolicyEventTask : ExternalProcessTaskBase<AzurePolicyEventTask>
     {
        
        /// <summary>
        /// Manage policy events.
        /// </summary>
        public AzurePolicyEventTask()
        {
            WithArguments("az policy event");
        }

        protected override string Description { get; set; }
        
     }
}
