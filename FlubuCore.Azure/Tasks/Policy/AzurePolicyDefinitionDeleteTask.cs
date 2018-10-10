
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Policy
{
     public partial class AzurePolicyDefinitionDeleteTask : ExternalProcessTaskBase<AzurePolicyDefinitionDeleteTask>
     {
        
        /// <summary>
        /// Delete a policy definition.
        /// </summary>
        public AzurePolicyDefinitionDeleteTask(string name = null)
        {
            WithArguments("az policy definition delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
     }
}
