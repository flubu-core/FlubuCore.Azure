
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDeviceC2dMessageTask : ExternalProcessTaskBase<AzureIotDeviceC2dMessageTask>
     {
        
        /// <summary>
        /// Cloud-to-device messaging commands.
        /// </summary>
        public AzureIotDeviceC2dMessageTask()
        {
            WithArguments("az iot device c2d-message");
        }

        protected override string Description { get; set; }
        
     }
}
