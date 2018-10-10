
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappCorsTask : ExternalProcessTaskBase<AzureFunctionappCorsTask>
     {
        
        /// <summary>
        /// Manage Cross-Origin Resource Sharing (CORS).
        /// </summary>
        public AzureFunctionappCorsTask()
        {
            WithArguments("az functionapp cors");
        }

        protected override string Description { get; set; }
        
     }
}
