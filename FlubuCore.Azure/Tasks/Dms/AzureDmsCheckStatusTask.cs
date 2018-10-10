
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dms
{
     public partial class AzureDmsCheckStatusTask : ExternalProcessTaskBase<AzureDmsCheckStatusTask>
     {
        
        /// <summary>
        /// Perform a health check and return the status of the service and virtual machine size.
        /// </summary>
        public AzureDmsCheckStatusTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az dms check-status");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
     }
}
