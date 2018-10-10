
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Appservice
{
     public partial class AzureAppservicePlanDeleteTask : ExternalProcessTaskBase<AzureAppservicePlanDeleteTask>
     {
        
        /// <summary>
        /// Delete an app service plan.
        /// </summary>
        public AzureAppservicePlanDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az appservice plan delete");
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
        
        /// <summary>
        /// Do not prompt for confirmation.
        /// </summary>
        public AzureAppservicePlanDeleteTask Yes(string yes = null)
        {
            WithArguments("--yes");
            if (!string.IsNullOrEmpty(yes))
            {
                 WithArguments(yes);
            }

            return this;
        }
     }
}
