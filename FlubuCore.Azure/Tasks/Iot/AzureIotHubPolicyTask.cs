
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubPolicyTask : ExternalProcessTaskBase<AzureIotHubPolicyTask>
     {
        
        /// <summary>
        /// Manage shared access policies of an IoT hub.
        /// </summary>
        public AzureIotHubPolicyTask()
        {
            WithArguments("az iot hub policy");
        }

        protected override string Description { get; set; }
        
     }
}
