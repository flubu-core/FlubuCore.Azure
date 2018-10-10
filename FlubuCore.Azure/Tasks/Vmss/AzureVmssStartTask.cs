
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssStartTask : ExternalProcessTaskBase<AzureVmssStartTask>
     {
        
        /// <summary>
        /// Start VMs within a VMSS.
        /// </summary>
        public AzureVmssStartTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vmss start");
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
        /// Space-separated list of IDs (ex: 1 2 3 ...) or * for all instances. If not provided, the action will be applied on the scaleset itself.
        /// </summary>
        public AzureVmssStartTask InstanceIds(string instanceIds = null)
        {
            WithArguments("--instance-ids");
            if (!string.IsNullOrEmpty(instanceIds))
            {
                 WithArguments(instanceIds);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureVmssStartTask NoWait(string noWait = null)
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
