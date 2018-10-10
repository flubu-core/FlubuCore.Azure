
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmPerformMaintenanceTask : ExternalProcessTaskBase<AzureVmPerformMaintenanceTask>
     {
        
        /// <summary>
        /// The operation to perform maintenance on a virtual machine.
        /// </summary>
        public AzureVmPerformMaintenanceTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vm perform-maintenance");
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
