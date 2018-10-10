
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureLabTask : ExternalProcessTaskBase<AzureLabTask>
     {
        
        /// <summary>
        /// Manage Azure DevTest Labs.
        /// </summary>
        public AzureLabTask()
        {
            WithArguments("az lab");
        }

        protected override string Description { get; set; }
        
     }
}
