
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubModuleTwinTask : ExternalProcessTaskBase<AzureIotHubModuleTwinTask>
     {
        
        /// <summary>
        /// Manage IoT device module twin configuration.
        /// </summary>
        public AzureIotHubModuleTwinTask()
        {
            WithArguments("az iot hub module-twin");
        }

        protected override string Description { get; set; }
        
     }
}
