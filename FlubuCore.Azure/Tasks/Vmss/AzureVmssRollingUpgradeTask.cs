
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssRollingUpgradeTask : ExternalProcessTaskBase<AzureVmssRollingUpgradeTask>
     {
        
        /// <summary>
        /// (PREVIEW) Manage rolling upgrades.
        /// </summary>
        public AzureVmssRollingUpgradeTask()
        {
            WithArguments("az vmss rolling-upgrade");
        }

        protected override string Description { get; set; }
        
     }
}
