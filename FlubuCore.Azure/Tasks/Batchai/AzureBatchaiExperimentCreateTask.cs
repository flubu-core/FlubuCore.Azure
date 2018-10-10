
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batchai
{
     public partial class AzureBatchaiExperimentCreateTask : ExternalProcessTaskBase<AzureBatchaiExperimentCreateTask>
     {
        
        /// <summary>
        /// Create an experiment.
        /// </summary>
        public AzureBatchaiExperimentCreateTask(string name = null ,  string resourceGroup = null ,  string workspace = null)
        {
            WithArguments("az batchai experiment create");
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
