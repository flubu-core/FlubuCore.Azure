
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubConfigurationTask : ExternalProcessTaskBase<AzureIotHubConfigurationTask>
     {
        
        /// <summary>
        /// Manage IoT device configurations at scale.
        /// </summary>
        public AzureIotHubConfigurationTask()
        {
            WithArguments("az iot hub configuration");
        }

        protected override string Description { get; set; }
        
     }
}
