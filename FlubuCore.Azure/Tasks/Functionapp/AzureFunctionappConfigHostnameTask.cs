
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappConfigHostnameTask : ExternalProcessTaskBase<AzureFunctionappConfigHostnameTask>
     {
        
        /// <summary>
        /// Configure hostnames for a function app.
        /// </summary>
        public AzureFunctionappConfigHostnameTask()
        {
            WithArguments("az functionapp config hostname");
        }

        protected override string Description { get; set; }
        
     }
}
