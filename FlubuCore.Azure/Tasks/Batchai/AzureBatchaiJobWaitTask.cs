
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batchai
{
     public partial class AzureBatchaiJobWaitTask : ExternalProcessTaskBase<AzureBatchaiJobWaitTask>
     {
        
        /// <summary>
        /// Waits for specified job completion and setups the exit code to the job's exit code.
        /// </summary>
        public AzureBatchaiJobWaitTask(string experiment = null ,  string name = null ,  string resourceGroup = null ,  string workspace = null)
        {
            WithArguments("az batchai job wait");
WithArguments("--experiment");
            if (!string.IsNullOrEmpty(experiment))
            {
                 WithArguments(experiment);
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
        
        /// <summary>
        /// Polling interval in sec.
        /// </summary>
        public AzureBatchaiJobWaitTask Interval(string interval = null)
        {
            WithArguments("--interval");
            if (!string.IsNullOrEmpty(interval))
            {
                 WithArguments(interval);
            }

            return this;
        }
     }
}
