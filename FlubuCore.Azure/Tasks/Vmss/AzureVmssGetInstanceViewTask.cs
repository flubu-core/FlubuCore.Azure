
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssGetInstanceViewTask : ExternalProcessTaskBase<AzureVmssGetInstanceViewTask>
     {
        
        /// <summary>
        /// View an instance of a VMSS.
        /// </summary>
        public AzureVmssGetInstanceViewTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vmss get-instance-view");
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
        /// A VM instance ID or "*" to list instance view for all VMs in a scale set.
        /// </summary>
        public AzureVmssGetInstanceViewTask InstanceId(string instanceId = null)
        {
            WithArguments("--instance-id");
            if (!string.IsNullOrEmpty(instanceId))
            {
                 WithArguments(instanceId);
            }

            return this;
        }
     }
}
