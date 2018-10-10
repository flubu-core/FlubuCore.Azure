
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureWebappTask : ExternalProcessTaskBase<AzureWebappTask>
     {
        
        /// <summary>
        /// Manage web apps.
        /// </summary>
        public AzureWebappTask()
        {
            WithArguments("az webapp");
        }

        protected override string Description { get; set; }
        
     }
}
