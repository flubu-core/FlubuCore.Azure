
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmAvailabilitySetDeleteTask : ExternalProcessTaskBase<AzureVmAvailabilitySetDeleteTask>
     {
        
        /// <summary>
        /// Delete an availability set.
        /// </summary>
        public AzureVmAvailabilitySetDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vm availability-set delete");
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
