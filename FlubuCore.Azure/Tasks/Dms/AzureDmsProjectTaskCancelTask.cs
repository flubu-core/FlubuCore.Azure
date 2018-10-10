
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dms
{
     public partial class AzureDmsProjectTaskCancelTask : ExternalProcessTaskBase<AzureDmsProjectTaskCancelTask>
     {
        
        /// <summary>
        /// Cancel a Task if it's currently queued or running.
        /// </summary>
        public AzureDmsProjectTaskCancelTask(string name = null ,  string projectName = null ,  string resourceGroup = null ,  string serviceName = null)
        {
            WithArguments("az dms project task cancel");
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
        
     }
}
