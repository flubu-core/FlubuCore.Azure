
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssRollingUpgradeStartTask : ExternalProcessTaskBase<AzureVmssRollingUpgradeStartTask>
     {
        
        /// <summary>
        /// Starts a rolling upgrade to move all virtual machine scale set instances to the latest available Platform Image OS version.
        /// </summary>
        public AzureVmssRollingUpgradeStartTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vmss rolling-upgrade start");
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
