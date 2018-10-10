
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigTask : ExternalProcessTaskBase<AzureWebappConfigTask>
     {
        
        /// <summary>
        /// Configure a web app.
        /// </summary>
        public AzureWebappConfigTask()
        {
            WithArguments("az webapp config");
        }

        protected override string Description { get; set; }
        
     }
}
