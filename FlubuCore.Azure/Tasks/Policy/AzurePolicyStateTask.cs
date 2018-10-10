
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Policy
{
     public partial class AzurePolicyStateTask : ExternalProcessTaskBase<AzurePolicyStateTask>
     {
        
        /// <summary>
        /// Manage policy compliance states.
        /// </summary>
        public AzurePolicyStateTask()
        {
            WithArguments("az policy state");
        }

        protected override string Description { get; set; }
        
     }
}
