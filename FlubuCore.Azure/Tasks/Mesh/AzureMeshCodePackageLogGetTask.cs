
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mesh
{
     public partial class AzureMeshCodePackageLogGetTask : ExternalProcessTaskBase<AzureMeshCodePackageLogGetTask>
     {
        
        /// <summary>
        /// Examine the logs for a codepackage.
        /// </summary>
        public AzureMeshCodePackageLogGetTask(string appName = null ,  string codePackageName = null ,  string replicaName = null ,  string resourceGroup = null ,  string serviceName = null)
        {
            WithArguments("az mesh code-package-log get");
WithArguments("--app-name");
            if (!string.IsNullOrEmpty(appName))
            {
                 WithArguments(appName);
            }

WithArguments("--code-package-name");
            if (!string.IsNullOrEmpty(codePackageName))
            {
                 WithArguments(codePackageName);
            }

WithArguments("--replica-name");
            if (!string.IsNullOrEmpty(replicaName))
            {
                 WithArguments(replicaName);
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
        /// Number of lines to show from the end of the logs. Default is 100.
        /// </summary>
        public AzureMeshCodePackageLogGetTask Tail(string tail = null)
        {
            WithArguments("--tail");
            if (!string.IsNullOrEmpty(tail))
            {
                 WithArguments(tail);
            }

            return this;
        }
     }
}
