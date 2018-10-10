
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmAvailabilitySetConvertTask : ExternalProcessTaskBase<AzureVmAvailabilitySetConvertTask>
     {
        
        /// <summary>
        /// Convert an Azure Availability Set to contain VMs with managed disks.
        /// </summary>
        public AzureVmAvailabilitySetConvertTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vm availability-set convert");
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
