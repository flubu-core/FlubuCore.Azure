
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acs
{
     public partial class AzureAcsKubernetesBrowseTask : ExternalProcessTaskBase<AzureAcsKubernetesBrowseTask>
     {
        
        /// <summary>
        /// Launch a proxy and browse the Kubernetes web UI.
        /// </summary>
        public AzureAcsKubernetesBrowseTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az acs kubernetes browse");
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
        public AzureAcsKubernetesBrowseTask DisableBrowser(string disableBrowser = null)
        {
            WithArguments("--disable-browser");
            if (!string.IsNullOrEmpty(disableBrowser))
            {
                 WithArguments(disableBrowser);
            }

            return this;
        }

        public AzureAcsKubernetesBrowseTask SshKeyFile(string sshKeyFile = null)
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
