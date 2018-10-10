
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acr
{
     public partial class AzureAcrBuildTaskTask : ExternalProcessTaskBase<AzureAcrBuildTaskTask>
     {
        
        /// <summary>
        /// Manage build definitions, which can be triggered by git commits or base image updates for OS & Framework Patching.
        /// </summary>
        public AzureAcrBuildTaskTask()
        {
            WithArguments("az acr build-task");
        }

        protected override string Description { get; set; }
        
     }
}
