
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureIotcentralTask : ExternalProcessTaskBase<AzureIotcentralTask>
     {
        
        /// <summary>
        /// Manage IoT Central assets.
        /// </summary>
        public AzureIotcentralTask()
        {
            WithArguments("az iotcentral");
        }

        protected override string Description { get; set; }
        
     }
}
