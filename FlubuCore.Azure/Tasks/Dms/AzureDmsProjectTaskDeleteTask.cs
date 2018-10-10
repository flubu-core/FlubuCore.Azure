
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dms
{
     public partial class AzureDmsProjectTaskDeleteTask : ExternalProcessTaskBase<AzureDmsProjectTaskDeleteTask>
     {
        
        /// <summary>
        /// Delete a migration Task.
        /// </summary>
        public AzureDmsProjectTaskDeleteTask(string name = null ,  string projectName = null ,  string resourceGroup = null ,  string serviceName = null)
        {
            WithArguments("az dms project task delete");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--project-name");
            if (!string.IsNullOrEmpty(projectName))
            {
                 WithArguments(projectName);
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
        /// If the Task is currently running, cancel the Task before deleting the Project.
        /// </summary>
        public AzureDmsProjectTaskDeleteTask DeleteRunningTasks(string deleteRunningTasks = null)
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
        public AzureDmsProjectTaskDeleteTask Yes(string yes = null)
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
