
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssReimageTask : ExternalProcessTaskBase<AzureVmssReimageTask>
     {
        
        /// <summary>
        /// Reimage VMs within a VMSS.
        /// </summary>
        public AzureVmssReimageTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vmss reimage");
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
        /// VM instance ID. If missing, reimage all instances.
        /// </summary>
        public AzureVmssReimageTask InstanceId(string instanceId = null)
        {
            WithArguments("--instance-id");
            if (!string.IsNullOrEmpty(instanceId))
            {
                 WithArguments(instanceId);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureVmssReimageTask NoWait(string noWait = null)
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
