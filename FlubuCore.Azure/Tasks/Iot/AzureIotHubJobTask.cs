
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubJobTask : ExternalProcessTaskBase<AzureIotHubJobTask>
     {
        
        /// <summary>
        /// Manage jobs in an IoT hub.
        /// </summary>
        public AzureIotHubJobTask()
        {
            WithArguments("az iot hub job");
        }

        protected override string Description { get; set; }
        
     }
}
