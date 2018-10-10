
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Dms
{
     public partial class AzureDmsProjectTaskCutoverTask : ExternalProcessTaskBase<AzureDmsProjectTaskCutoverTask>
     {
        
        /// <summary>
        /// For an online migration task, complete the migration by performing a cutover.
        /// </summary>
        public AzureDmsProjectTaskCutoverTask(string databaseName = null ,  string name = null ,  string projectName = null ,  string resourceGroup = null ,  string serviceName = null)
        {
            WithArguments("az dms project task cutover");
WithArguments("--database-name");
            if (!string.IsNullOrEmpty(databaseName))
            {
                 WithArguments(databaseName);
            }

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
