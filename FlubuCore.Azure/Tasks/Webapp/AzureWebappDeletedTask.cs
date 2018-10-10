
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappDeletedTask : ExternalProcessTaskBase<AzureWebappDeletedTask>
     {
        
        /// <summary>
        /// Manage deleted web apps.
        /// </summary>
        public AzureWebappDeletedTask()
        {
            WithArguments("az webapp deleted");
        }

        protected override string Description { get; set; }
        
     }
}
