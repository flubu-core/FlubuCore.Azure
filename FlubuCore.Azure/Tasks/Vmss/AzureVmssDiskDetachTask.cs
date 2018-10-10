
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssDiskDetachTask : ExternalProcessTaskBase<AzureVmssDiskDetachTask>
     {
        
        /// <summary>
        /// Detach managed data disks from a scale set or its instances.
        /// </summary>
        public AzureVmssDiskDetachTask(string lun = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vmss disk detach");
WithArguments("--lun");
            if (!string.IsNullOrEmpty(lun))
            {
                 WithArguments(lun);
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
        /// Scale set VM instance id.
        /// </summary>
        public AzureVmssDiskDetachTask InstanceId(string instanceId = null)
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
