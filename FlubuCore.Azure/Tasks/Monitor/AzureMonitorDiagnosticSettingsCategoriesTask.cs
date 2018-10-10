
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorDiagnosticSettingsCategoriesTask : ExternalProcessTaskBase<AzureMonitorDiagnosticSettingsCategoriesTask>
     {
        
        /// <summary>
        /// Retrieve service diagnostic settings categories.
        /// </summary>
        public AzureMonitorDiagnosticSettingsCategoriesTask()
        {
            WithArguments("az monitor diagnostic-settings categories");
        }

        protected override string Description { get; set; }
        
     }
}
