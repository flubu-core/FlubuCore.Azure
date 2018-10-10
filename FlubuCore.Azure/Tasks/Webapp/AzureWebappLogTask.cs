
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappLogTask : ExternalProcessTaskBase<AzureWebappLogTask>
     {
        
        /// <summary>
        /// Manage web app logs.
        /// </summary>
        public AzureWebappLogTask()
        {
            WithArguments("az webapp log");
        }

        protected override string Description { get; set; }
        
     }
}
