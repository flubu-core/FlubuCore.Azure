
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks
{
     public partial class AzureCloudTask : ExternalProcessTaskBase<AzureCloudTask>
     {
        
        /// <summary>
        /// Manage registered Azure clouds.
        /// </summary>
        public AzureCloudTask()
        {
            WithArguments("az cloud");
        }

        protected override string Description { get; set; }
        
     }
}
