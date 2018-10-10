
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureFunctionappTask : ExternalProcessTaskBase<AzureFunctionappTask>
     {
        
        /// <summary>
        /// Manage function apps.
        /// </summary>
        public AzureFunctionappTask()
        {
            WithArguments("az functionapp");
        }

        protected override string Description { get; set; }
        
     }
}
