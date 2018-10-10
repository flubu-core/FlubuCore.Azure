
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssScaleTask : ExternalProcessTaskBase<AzureVmssScaleTask>
     {
        
        /// <summary>
        /// Change the number of VMs within a VMSS.
        /// </summary>
        public AzureVmssScaleTask(string name = null ,  string newCapacity = null ,  string resourceGroup = null)
        {
            WithArguments("az vmss scale");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--new-capacity");
            if (!string.IsNullOrEmpty(newCapacity))
            {
                 WithArguments(newCapacity);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureVmssScaleTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }
     }
}
