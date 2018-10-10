
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappConfigSslTask : ExternalProcessTaskBase<AzureFunctionappConfigSslTask>
     {
        
        /// <summary>
        /// Configure SSL certificates.
        /// </summary>
        public AzureFunctionappConfigSslTask()
        {
            WithArguments("az functionapp config ssl");
        }

        protected override string Description { get; set; }
        
     }
}
