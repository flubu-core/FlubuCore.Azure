
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssRollingUpgradeGetLatestTask : ExternalProcessTaskBase<AzureVmssRollingUpgradeGetLatestTask>
     {
        
        /// <summary>
        /// Gets the status of the latest virtual machine scale set rolling upgrade.
        /// </summary>
        public AzureVmssRollingUpgradeGetLatestTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vmss rolling-upgrade get-latest");
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
