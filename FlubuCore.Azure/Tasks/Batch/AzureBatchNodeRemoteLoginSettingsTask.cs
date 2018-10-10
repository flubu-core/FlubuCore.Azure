
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Batch
{
     public partial class AzureBatchNodeRemoteLoginSettingsTask : ExternalProcessTaskBase<AzureBatchNodeRemoteLoginSettingsTask>
     {
        
        /// <summary>
        /// Retrieve the remote login settings for a Batch compute node.
        /// </summary>
        public AzureBatchNodeRemoteLoginSettingsTask()
        {
            WithArguments("az batch node remote-login-settings");
        }

        protected override string Description { get; set; }
        
     }
}
