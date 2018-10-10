
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iotcentral
{
     public partial class AzureIotcentralAppTask : ExternalProcessTaskBase<AzureIotcentralAppTask>
     {
        
        /// <summary>
        /// Manage IoT Central applications.
        /// </summary>
        public AzureIotcentralAppTask()
        {
            WithArguments("az iotcentral app");
        }

        protected override string Description { get; set; }
        
     }
}
