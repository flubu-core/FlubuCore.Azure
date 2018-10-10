
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acs
{
     public partial class AzureAcsKubernetesGetCredentialsTask : ExternalProcessTaskBase<AzureAcsKubernetesGetCredentialsTask>
     {
        
        /// <summary>
        /// Download and install credentials to access a cluster.  This command requires the same private-key used to create the cluster.
        /// </summary>
        public AzureAcsKubernetesGetCredentialsTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az acs kubernetes get-credentials");
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
        /// Where to install the kubectl config file.
        /// </summary>
        public AzureAcsKubernetesGetCredentialsTask File(string file = null)
        {
            WithArguments("--file");
            if (!string.IsNullOrEmpty(file))
            {
                 WithArguments(file);
            }

            return this;
        }

        /// <summary>
        /// Path to an SSH key file to use.
        /// </summary>
        public AzureAcsKubernetesGetCredentialsTask SshKeyFile(string sshKeyFile = null)
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
