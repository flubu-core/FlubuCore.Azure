
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigHostnameTask : ExternalProcessTaskBase<AzureWebappConfigHostnameTask>
     {
        
        /// <summary>
        /// Configure hostnames for a web app.
        /// </summary>
        public AzureWebappConfigHostnameTask()
        {
            WithArguments("az webapp config hostname");
        }

        protected override string Description { get; set; }
        
     }
}
