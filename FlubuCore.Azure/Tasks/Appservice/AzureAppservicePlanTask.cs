
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Appservice
{
     public partial class AzureAppservicePlanTask : ExternalProcessTaskBase<AzureAppservicePlanTask>
     {
        
        /// <summary>
        /// Manage app service plans.
        /// </summary>
        public AzureAppservicePlanTask()
        {
            WithArguments("az appservice plan");
        }

        protected override string Description { get; set; }
        
     }
}
