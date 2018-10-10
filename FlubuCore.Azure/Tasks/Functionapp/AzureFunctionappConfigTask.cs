
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappConfigTask : ExternalProcessTaskBase<AzureFunctionappConfigTask>
     {
        
        /// <summary>
        /// Configure a function app.
        /// </summary>
        public AzureFunctionappConfigTask()
        {
            WithArguments("az functionapp config");
        }

        protected override string Description { get; set; }
        
     }
}
