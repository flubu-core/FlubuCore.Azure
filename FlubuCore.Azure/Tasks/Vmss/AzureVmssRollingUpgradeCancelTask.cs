
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssRollingUpgradeCancelTask : ExternalProcessTaskBase<AzureVmssRollingUpgradeCancelTask>
     {
        
        /// <summary>
        /// Cancels the current virtual machine scale set rolling upgrade.
        /// </summary>
        public AzureVmssRollingUpgradeCancelTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vmss rolling-upgrade cancel");
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
