
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubRouteTask : ExternalProcessTaskBase<AzureIotHubRouteTask>
     {
        
        /// <summary>
        /// Manage routes of an IoT hub.
        /// </summary>
        public AzureIotHubRouteTask()
        {
            WithArguments("az iot hub route");
        }

        protected override string Description { get; set; }
        
     }
}
