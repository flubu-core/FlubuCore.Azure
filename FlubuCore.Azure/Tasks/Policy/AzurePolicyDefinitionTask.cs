
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Policy
{
     public partial class AzurePolicyDefinitionTask : ExternalProcessTaskBase<AzurePolicyDefinitionTask>
     {
        
        /// <summary>
        /// Manage resource policy definitions.
        /// </summary>
        public AzurePolicyDefinitionTask()
        {
            WithArguments("az policy definition");
        }

        protected override string Description { get; set; }
        
     }
}
