
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappRemoteConnectionTask : ExternalProcessTaskBase<AzureWebappRemoteConnectionTask>
     {
        
        /// <summary>
        /// Create a remote connection using a tcp tunnel to your web app.
        /// </summary>
        public AzureWebappRemoteConnectionTask()
        {
            WithArguments("az webapp remote-connection");
        }

        protected override string Description { get; set; }
        
     }
}
