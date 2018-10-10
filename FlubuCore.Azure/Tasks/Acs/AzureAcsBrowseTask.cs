
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acs
{
     public partial class AzureAcsBrowseTask : ExternalProcessTaskBase<AzureAcsBrowseTask>
     {
        
        /// <summary>
        /// Show the dashboard for a service container's orchestrator in a web browser.
        /// </summary>
        public AzureAcsBrowseTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az acs browse");
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
        /// Do not open browser after opening a proxy to the cluster web user interface.
        /// </summary>
        public AzureAcsBrowseTask DisableBrowser(string disableBrowser = null)
        {
            WithArguments("--disable-browser");
            if (!string.IsNullOrEmpty(disableBrowser))
            {
                 WithArguments(disableBrowser);
            }

            return this;
        }

        /// <summary>
        /// If set a path to an SSH key to use, only applies to DCOS.
        /// </summary>
        public AzureAcsBrowseTask SshKeyFile(string sshKeyFile = null)
        {
            WithArguments("--ssh-key-file");
            if (!string.IsNullOrEmpty(sshKeyFile))
            {
                 WithArguments(sshKeyFile);
            }

            return this;
        }
     }
}
