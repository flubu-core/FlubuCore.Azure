
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Policy
{
     public partial class AzurePolicySetDefinitionDeleteTask : ExternalProcessTaskBase<AzurePolicySetDefinitionDeleteTask>
     {
        
        /// <summary>
        /// Delete a policy set definition.
        /// </summary>
        public AzurePolicySetDefinitionDeleteTask(string name = null)
        {
            WithArguments("az policy set-definition delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
     }
}
