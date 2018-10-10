
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsTransformCreateTask : ExternalProcessTaskBase<AzureAmsTransformCreateTask>
     {
        
        /// <summary>
        /// Create a transform.
        /// </summary>
        public AzureAmsTransformCreateTask(string accountName = null ,  string name = null ,  string presetNames = null ,  string resourceGroup = null)
        {
            WithArguments("az ams transform create");
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

WithArguments("--preset-names");
            if (!string.IsNullOrEmpty(presetNames))
            {
                 WithArguments(presetNames);
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
