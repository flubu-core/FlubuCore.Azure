
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigContainerTask : ExternalProcessTaskBase<AzureWebappConfigContainerTask>
     {
        
        /// <summary>
        /// Manage web app container settings.
        /// </summary>
        public AzureWebappConfigContainerTask()
        {
            WithArguments("az webapp config container");
        }

        protected override string Description { get; set; }
        
     }
}
