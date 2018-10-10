
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acs
{
     public partial class AzureAcsKubernetesInstallCliTask : ExternalProcessTaskBase<AzureAcsKubernetesInstallCliTask>
     {
        
        /// <summary>
        /// Download and install the Kubernetes command-line tool for a cluster.
        /// </summary>
        public AzureAcsKubernetesInstallCliTask()
        {
            WithArguments("az acs kubernetes install-cli");
        }

        protected override string Description { get; set; }
        
        public AzureAcsKubernetesInstallCliTask ClientVersion(string clientVersion = null)
        {
            WithArguments("--client-version");
            if (!string.IsNullOrEmpty(clientVersion))
            {
                 WithArguments(clientVersion);
            }

            return this;
        }

        public AzureAcsKubernetesInstallCliTask InstallLocation(string installLocation = null)
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
