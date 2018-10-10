
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureIotTask : ExternalProcessTaskBase<AzureIotTask>
     {
        
        /// <summary>
        /// Manage Internet of Things (IoT) assets.
        /// </summary>
        public AzureIotTask()
        {
            WithArguments("az iot");
        }

        protected override string Description { get; set; }
        
     }
}
