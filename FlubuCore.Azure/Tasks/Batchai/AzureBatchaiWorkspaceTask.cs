
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batchai
{
     public partial class AzureBatchaiWorkspaceTask : ExternalProcessTaskBase<AzureBatchaiWorkspaceTask>
     {
        
        /// <summary>
        /// Commands to manage workspaces.
        /// </summary>
        public AzureBatchaiWorkspaceTask()
        {
            WithArguments("az batchai workspace");
        }

        protected override string Description { get; set; }
        
     }
}
