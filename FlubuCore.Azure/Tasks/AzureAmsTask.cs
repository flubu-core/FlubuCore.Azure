
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureAmsTask : ExternalProcessTaskBase<AzureAmsTask>
     {
        
        /// <summary>
        /// Manage Azure Media Services resources.
        /// </summary>
        public AzureAmsTask()
        {
            WithArguments("az ams");
        }

        protected override string Description { get; set; }
        
     }
}
