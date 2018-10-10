
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Functionapp
{
     public partial class AzureFunctionappConfigAppsettingsTask : ExternalProcessTaskBase<AzureFunctionappConfigAppsettingsTask>
     {
        
        /// <summary>
        /// Configure function app settings.
        /// </summary>
        public AzureFunctionappConfigAppsettingsTask()
        {
            WithArguments("az functionapp config appsettings");
        }

        protected override string Description { get; set; }
        
     }
}
