
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batchai
{
     public partial class AzureBatchaiClusterAutoScaleTask : ExternalProcessTaskBase<AzureBatchaiClusterAutoScaleTask>
     {
        
        /// <summary>
        /// Set auto-scale parameters for a cluster.
        /// </summary>
        public AzureBatchaiClusterAutoScaleTask(string max = null ,  string min = null ,  string name = null ,  string resourceGroup = null ,  string workspace = null)
        {
            WithArguments("az batchai cluster auto-scale");
WithArguments("--max");
            if (!string.IsNullOrEmpty(max))
            {
                 WithArguments(max);
            }

WithArguments("--min");
            if (!string.IsNullOrEmpty(min))
            {
                 WithArguments(min);
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

WithArguments("--workspace");
            if (!string.IsNullOrEmpty(workspace))
            {
                 WithArguments(workspace);
            }

        }

        protected override string Description { get; set; }
        
     }
}
