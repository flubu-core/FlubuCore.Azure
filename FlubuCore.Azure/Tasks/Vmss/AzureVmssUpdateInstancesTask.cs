
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssUpdateInstancesTask : ExternalProcessTaskBase<AzureVmssUpdateInstancesTask>
     {
        
        /// <summary>
        /// Upgrade VMs within a VMSS.
        /// </summary>
        public AzureVmssUpdateInstancesTask(string instanceIds = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vmss update-instances");
WithArguments("--instance-ids");
            if (!string.IsNullOrEmpty(instanceIds))
            {
                 WithArguments(instanceIds);
            }

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
        
        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureVmssUpdateInstancesTask NoWait(string noWait = null)
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
