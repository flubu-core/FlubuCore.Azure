
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Aks
{
     public partial class AzureAksGetCredentialsTask : ExternalProcessTaskBase<AzureAksGetCredentialsTask>
     {
        
        /// <summary>
        /// Get access credentials for a managed Kubernetes cluster.
        /// </summary>
        public AzureAksGetCredentialsTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az aks get-credentials");
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
        /// Get cluster administrator credentials.  Default: cluster user credentials.
        /// </summary>
        public AzureAksGetCredentialsTask Admin(string admin = null)
        {
            WithArguments("--admin");
            if (!string.IsNullOrEmpty(admin))
            {
                 WithArguments(admin);
            }

            return this;
        }

        /// <summary>
        /// Kubernetes configuration file to update. Use "-" to print YAML to stdout instead.
        /// </summary>
        public AzureAksGetCredentialsTask File(string file = null)
        {
            WithArguments("--file");
            if (!string.IsNullOrEmpty(file))
            {
                 WithArguments(file);
            }

            return this;
        }
     }
}
