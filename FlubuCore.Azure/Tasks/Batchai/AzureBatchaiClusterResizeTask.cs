
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batchai
{
     public partial class AzureBatchaiClusterResizeTask : ExternalProcessTaskBase<AzureBatchaiClusterResizeTask>
     {
        
        /// <summary>
        /// Resize a cluster.
        /// </summary>
        public AzureBatchaiClusterResizeTask(string name = null ,  string resourceGroup = null ,  string target = null ,  string workspace = null)
        {
            WithArguments("az batchai cluster resize");
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

WithArguments("--target");
            if (!string.IsNullOrEmpty(target))
            {
                 WithArguments(target);
            }

WithArguments("--workspace");
            if (!string.IsNullOrEmpty(workspace))
            {
                 WithArguments(workspace);
            }

        }

        protected override string Description { get; set; }
        
     }
}
