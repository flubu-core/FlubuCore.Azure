
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigSslTask : ExternalProcessTaskBase<AzureWebappConfigSslTask>
     {
        
        /// <summary>
        /// Configure SSL certificates for web apps.
        /// </summary>
        public AzureWebappConfigSslTask()
        {
            WithArguments("az webapp config ssl");
        }

        protected override string Description { get; set; }
        
     }
}
