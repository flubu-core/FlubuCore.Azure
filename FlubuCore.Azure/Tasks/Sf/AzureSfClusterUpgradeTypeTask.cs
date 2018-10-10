
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfClusterUpgradeTypeTask : ExternalProcessTaskBase<AzureSfClusterUpgradeTypeTask>
     {
        
        /// <summary>
        /// Manage the upgrade type of a cluster.
        /// </summary>
        public AzureSfClusterUpgradeTypeTask()
        {
            WithArguments("az sf cluster upgrade-type");
        }

        protected override string Description { get; set; }
        
     }
}
