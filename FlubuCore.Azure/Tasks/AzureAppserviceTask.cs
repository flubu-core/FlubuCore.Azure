
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureAppserviceTask : ExternalProcessTaskBase<AzureAppserviceTask>
     {
        
        /// <summary>
        /// Manage App Service plans.
        /// </summary>
        public AzureAppserviceTask()
        {
            WithArguments("az appservice");
        }

        protected override string Description { get; set; }
        
     }
}
