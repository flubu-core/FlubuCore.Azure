
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mesh
{
     public partial class AzureMeshCodePackageLogTask : ExternalProcessTaskBase<AzureMeshCodePackageLogTask>
     {
        
        /// <summary>
        /// Examine the logs for a codepackage.
        /// </summary>
        public AzureMeshCodePackageLogTask()
        {
            WithArguments("az mesh code-package-log");
        }

        protected override string Description { get; set; }
        
     }
}
