
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Policy
{
     public partial class AzurePolicySetDefinitionTask : ExternalProcessTaskBase<AzurePolicySetDefinitionTask>
     {
        
        /// <summary>
        /// Manage resource policy set definitions.
        /// </summary>
        public AzurePolicySetDefinitionTask()
        {
            WithArguments("az policy set-definition");
        }

        protected override string Description { get; set; }
        
     }
}
