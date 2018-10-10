
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorAutoscaleSettingsGetParametersTemplateTask : ExternalProcessTaskBase<AzureMonitorAutoscaleSettingsGetParametersTemplateTask>
     {
        
        /// <summary>
        /// Scaffold fully formed autoscale-settings' parameters as json template.
        /// </summary>
        public AzureMonitorAutoscaleSettingsGetParametersTemplateTask()
        {
            WithArguments("az monitor autoscale-settings get-parameters-template");
        }

        protected override string Description { get; set; }
        
     }
}
