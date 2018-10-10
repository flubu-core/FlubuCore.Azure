
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsJobDeleteTask : ExternalProcessTaskBase<AzureAmsJobDeleteTask>
     {
        
        /// <summary>
        /// Delete a job.
        /// </summary>
        public AzureAmsJobDeleteTask(string accountName = null ,  string name = null ,  string resourceGroup = null ,  string transformName = null)
        {
            WithArguments("az ams job delete");
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
        
     }
}
