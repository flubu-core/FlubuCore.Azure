
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigAppsettingsTask : ExternalProcessTaskBase<AzureWebappConfigAppsettingsTask>
     {
        
        /// <summary>
        /// Configure web app settings.
        /// </summary>
        public AzureWebappConfigAppsettingsTask()
        {
            WithArguments("az webapp config appsettings");
        }

        protected override string Description { get; set; }
        
     }
}
