
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batchai
{
     public partial class AzureBatchaiWorkspaceCreateTask : ExternalProcessTaskBase<AzureBatchaiWorkspaceCreateTask>
     {
        
        /// <summary>
        /// Create a workspace.
        /// </summary>
        public AzureBatchaiWorkspaceCreateTask(string resourceGroup = null ,  string workspace = null)
        {
            WithArguments("az batchai workspace create");
WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--workspace");
            if (!string.IsNullOrEmpty(workspace))
            {
                 WithArguments(workspace);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Location of the workspace. If omitted, the location of the resource group will be used.
        /// </summary>
        public AzureBatchaiWorkspaceCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }
     }
}
