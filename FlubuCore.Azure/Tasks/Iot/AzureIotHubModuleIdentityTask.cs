
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubModuleIdentityTask : ExternalProcessTaskBase<AzureIotHubModuleIdentityTask>
     {
        
        /// <summary>
        /// Manage IoT device modules.
        /// </summary>
        public AzureIotHubModuleIdentityTask()
        {
            WithArguments("az iot hub module-identity");
        }

        protected override string Description { get; set; }
        
     }
}
