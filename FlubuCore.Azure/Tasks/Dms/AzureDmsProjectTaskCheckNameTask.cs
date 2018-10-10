
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dms
{
     public partial class AzureDmsProjectTaskCheckNameTask : ExternalProcessTaskBase<AzureDmsProjectTaskCheckNameTask>
     {
        
        /// <summary>
        /// Check if a given Task name is available within a given instance of DMS as well as the name's validity.
        /// </summary>
        public AzureDmsProjectTaskCheckNameTask(string name = null ,  string projectName = null ,  string resourceGroup = null ,  string serviceName = null)
        {
            WithArguments("az dms project task check-name");
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
