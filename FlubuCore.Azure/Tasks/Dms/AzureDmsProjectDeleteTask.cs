
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dms
{
     public partial class AzureDmsProjectDeleteTask : ExternalProcessTaskBase<AzureDmsProjectDeleteTask>
     {
        
        /// <summary>
        /// Delete a Project.
        /// </summary>
        public AzureDmsProjectDeleteTask(string name = null ,  string resourceGroup = null ,  string serviceName = null)
        {
            WithArguments("az dms project delete");
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

WithArguments("--service-name");
            if (!string.IsNullOrEmpty(serviceName))
            {
                 WithArguments(serviceName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Cancel any running tasks before deleting the Project.
        /// </summary>
        public AzureDmsProjectDeleteTask DeleteRunningTasks(string deleteRunningTasks = null)
        {
            WithArguments("--delete-running-tasks");
            if (!string.IsNullOrEmpty(deleteRunningTasks))
            {
                 WithArguments(deleteRunningTasks);
            }

            return this;
        }

        /// <summary>
        /// Do not prompt for confirmation.
        /// </summary>
        public AzureDmsProjectDeleteTask Yes(string yes = null)
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
