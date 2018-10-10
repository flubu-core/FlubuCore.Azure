
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappRemoteConnectionCreateTask : ExternalProcessTaskBase<AzureWebappRemoteConnectionCreateTask>
     {
        
        /// <summary>
        /// Creates a remote connection using a tcp tunnel to your web app.
        /// </summary>
        public AzureWebappRemoteConnectionCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az webapp remote-connection create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Port for the remote connection. Default: Random available port.
        /// </summary>
        public AzureWebappRemoteConnectionCreateTask Port(string port = null)
        {
            WithArguments("--port");
            if (!string.IsNullOrEmpty(port))
            {
                 WithArguments(port);
            }

            return this;
        }

        public AzureWebappRemoteConnectionCreateTask Slot(string slot = null)
        {
            WithArguments("--slot");
            if (!string.IsNullOrEmpty(slot))
            {
                 WithArguments(slot);
            }

            return this;
        }
     }
}
