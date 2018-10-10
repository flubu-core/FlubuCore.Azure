
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Ams
{
     public partial class AzureAmsAccountDeleteTask : ExternalProcessTaskBase<AzureAmsAccountDeleteTask>
     {
        
        /// <summary>
        /// Delete an Azure Media Services account.
        /// </summary>
        public AzureAmsAccountDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az ams account delete");
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

        }

        protected override string Description { get; set; }
        
     }
}
