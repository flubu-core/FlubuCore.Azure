
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchNodeRemoteDesktopTask : ExternalProcessTaskBase<AzureBatchNodeRemoteDesktopTask>
     {
        
        /// <summary>
        /// Retrieve the remote desktop protocol file for a Batch compute node.
        /// </summary>
        public AzureBatchNodeRemoteDesktopTask()
        {
            WithArguments("az batch node remote-desktop");
        }

        protected override string Description { get; set; }
        
     }
}
