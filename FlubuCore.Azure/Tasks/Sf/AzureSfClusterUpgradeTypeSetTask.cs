
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfClusterUpgradeTypeSetTask : ExternalProcessTaskBase<AzureSfClusterUpgradeTypeSetTask>
     {
        
        /// <summary>
        /// Change the  upgrade type for a cluster.
        /// </summary>
        public AzureSfClusterUpgradeTypeSetTask(string clusterName = null ,  string resourceGroup = null ,  string upgradeMode = null)
        {
            WithArguments("az sf cluster upgrade-type set");
WithArguments("--cluster-name");
            if (!string.IsNullOrEmpty(clusterName))
            {
                 WithArguments(clusterName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--upgrade-mode");
            if (!string.IsNullOrEmpty(upgradeMode))
            {
                 WithArguments(upgradeMode);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Cluster code version.
        /// </summary>
        public AzureSfClusterUpgradeTypeSetTask Version(string version = null)
        {
            WithArguments("--version");
            if (!string.IsNullOrEmpty(version))
            {
                 WithArguments(version);
            }

            return this;
        }
     }
}
