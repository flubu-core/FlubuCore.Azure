
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Aks
{
     public partial class AzureAksInstallCliTask : ExternalProcessTaskBase<AzureAksInstallCliTask>
     {
        
        /// <summary>
        /// Download and install kubectl, the Kubernetes command-line tool.
        /// </summary>
        public AzureAksInstallCliTask()
        {
            WithArguments("az aks install-cli");
        }

        protected override string Description { get; set; }
        
        public AzureAksInstallCliTask ClientVersion(string clientVersion = null)
        {
            WithArguments("--client-version");
            if (!string.IsNullOrEmpty(clientVersion))
            {
                 WithArguments(clientVersion);
            }

            return this;
        }

        public AzureAksInstallCliTask InstallLocation(string installLocation = null)
        {
            WithArguments("--install-location");
            if (!string.IsNullOrEmpty(installLocation))
            {
                 WithArguments(installLocation);
            }

            return this;
        }
     }
}
