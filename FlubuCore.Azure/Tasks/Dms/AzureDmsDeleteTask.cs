
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dms
{
     public partial class AzureDmsDeleteTask : ExternalProcessTaskBase<AzureDmsDeleteTask>
     {
        
        /// <summary>
        /// Delete an instance of the Data Migration Service.
        /// </summary>
        public AzureDmsDeleteTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az dms delete");
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
        /// Cancel any running tasks before deleting the service.
        /// </summary>
        public AzureDmsDeleteTask DeleteRunningTasks(string deleteRunningTasks = null)
        {
            WithArguments("--delete-running-tasks");
            if (!string.IsNullOrEmpty(deleteRunningTasks))
            {
                 WithArguments(deleteRunningTasks);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureDmsDeleteTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Do not prompt for confirmation.
        /// </summary>
        public AzureDmsDeleteTask Yes(string yes = null)
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
