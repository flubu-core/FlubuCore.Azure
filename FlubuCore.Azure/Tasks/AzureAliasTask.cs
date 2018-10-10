
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureAliasTask : ExternalProcessTaskBase<AzureAliasTask>
     {
        
        /// <summary>
        /// Manage Azure CLI Aliases.
        /// </summary>
        public AzureAliasTask()
        {
            WithArguments("az alias");
        }

        protected override string Description { get; set; }
        
     }
}
