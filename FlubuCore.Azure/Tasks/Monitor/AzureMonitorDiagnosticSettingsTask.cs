
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorDiagnosticSettingsTask : ExternalProcessTaskBase<AzureMonitorDiagnosticSettingsTask>
     {
        
        /// <summary>
        /// Manage service diagnostic settings.
        /// </summary>
        public AzureMonitorDiagnosticSettingsTask()
        {
            WithArguments("az monitor diagnostic-settings");
        }

        protected override string Description { get; set; }
        
     }
}
