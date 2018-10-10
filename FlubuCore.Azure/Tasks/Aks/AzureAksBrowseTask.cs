
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Aks
{
     public partial class AzureAksBrowseTask : ExternalProcessTaskBase<AzureAksBrowseTask>
     {
        
        /// <summary>
        /// Show the dashboard for a Kubernetes cluster in a web browser.
        /// </summary>
        public AzureAksBrowseTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az aks browse");
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
        /// Don't launch a web browser after establishing port-forwarding.
        /// </summary>
        public AzureAksBrowseTask DisableBrowser(string disableBrowser = null)
        {
            WithArguments("--disable-browser");
            if (!string.IsNullOrEmpty(disableBrowser))
            {
                 WithArguments(disableBrowser);
            }

            return this;
        }

        /// <summary>
        /// The listening port for the dashboard.
        /// </summary>
        public AzureAksBrowseTask ListenPort(string listenPort = null)
        {
            WithArguments("--listen-port");
            if (!string.IsNullOrEmpty(listenPort))
            {
                 WithArguments(listenPort);
            }

            return this;
        }
     }
}
