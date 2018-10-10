
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotEdgeTask : ExternalProcessTaskBase<AzureIotEdgeTask>
     {
        
        /// <summary>
        /// Manage IoT solutions on the Edge.
        /// </summary>
        public AzureIotEdgeTask()
        {
            WithArguments("az iot edge");
        }

        protected override string Description { get; set; }
        
     }
}
