
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acs
{
     public partial class AzureAcsDcosInstallCliTask : ExternalProcessTaskBase<AzureAcsDcosInstallCliTask>
     {
        
        /// <summary>
        /// Download and install the DC/OS command-line tool for a cluster.
        /// </summary>
        public AzureAcsDcosInstallCliTask()
        {
            WithArguments("az acs dcos install-cli");
        }

        protected override string Description { get; set; }
        
        public AzureAcsDcosInstallCliTask ClientVersion(string clientVersion = null)
        {
            WithArguments("--client-version");
            if (!string.IsNullOrEmpty(clientVersion))
            {
                 WithArguments(clientVersion);
            }

            return this;
        }

        public AzureAcsDcosInstallCliTask InstallLocation(string installLocation = null)
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
