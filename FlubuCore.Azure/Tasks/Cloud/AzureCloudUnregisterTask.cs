
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Cloud
{
     public partial class AzureCloudUnregisterTask : ExternalProcessTaskBase<AzureCloudUnregisterTask>
     {
        
        /// <summary>
        /// Unregister a cloud.
        /// </summary>
        public AzureCloudUnregisterTask(string name = null)
        {
            WithArguments("az cloud unregister");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
     }
}
