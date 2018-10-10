
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acs
{
     public partial class AzureAcsDcosBrowseTask : ExternalProcessTaskBase<AzureAcsDcosBrowseTask>
     {
        
        /// <summary>
        /// Creates an SSH tunnel to the Azure container service, and opens the Mesosphere DC/OS dashboard in the browser.
        /// </summary>
        public AzureAcsDcosBrowseTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az acs dcos browse");
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
        public AzureAcsDcosBrowseTask DisableBrowser(string disableBrowser = null)
        {
            WithArguments("--disable-browser");
            if (!string.IsNullOrEmpty(disableBrowser))
            {
                 WithArguments(disableBrowser);
            }

            return this;
        }

        /// <summary>
        /// Path to an SSH key file to use.
        /// </summary>
        public AzureAcsDcosBrowseTask SshKeyFile(string sshKeyFile = null)
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
