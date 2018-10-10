
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsJobCancelTask : ExternalProcessTaskBase<AzureAmsJobCancelTask>
     {
        
        /// <summary>
        /// Cancel a job.
        /// </summary>
        public AzureAmsJobCancelTask(string accountName = null ,  string name = null ,  string resourceGroup = null ,  string transformName = null)
        {
            WithArguments("az ams job cancel");
WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
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

WithArguments("--transform-name");
            if (!string.IsNullOrEmpty(transformName))
            {
                 WithArguments(transformName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Delete the job being cancelled.
        /// </summary>
        public AzureAmsJobCancelTask Delete(string delete = null)
        {
            WithArguments("--delete");
            if (!string.IsNullOrEmpty(delete))
            {
                 WithArguments(delete);
            }

            return this;
        }
     }
}
