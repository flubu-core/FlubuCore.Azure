
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssPerformMaintenanceTask : ExternalProcessTaskBase<AzureVmssPerformMaintenanceTask>
     {
        
        /// <summary>
        /// Perform maintenance on one or more virtual machines in a VM scale set.
        /// </summary>
        public AzureVmssPerformMaintenanceTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vmss perform-maintenance");
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
        public AzureVmssPerformMaintenanceTask InstanceIds(string instanceIds = null)
        {
            WithArguments("--instance-ids");
            if (!string.IsNullOrEmpty(instanceIds))
            {
                 WithArguments(instanceIds);
            }

            return this;
        }
     }
}
