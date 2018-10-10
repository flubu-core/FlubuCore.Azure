
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmUserUpdateTask : ExternalProcessTaskBase<AzureVmUserUpdateTask>
     {
        
        /// <summary>
        /// Update a user account.
        /// </summary>
        public AzureVmUserUpdateTask(string name = null ,  string resourceGroup = null ,  string username = null)
        {
            WithArguments("az vm user update");
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

WithArguments("--username");
            if (!string.IsNullOrEmpty(username))
            {
                 WithArguments(username);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureVmUserUpdateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// The user password.
        /// </summary>
        public AzureVmUserUpdateTask Password(string password = null)
        {
            WithArguments("--password");
            if (!string.IsNullOrEmpty(password))
            {
                 WithArguments(password);
            }

            return this;
        }

        /// <summary>
        /// SSH public key file value or public key file path.
        /// </summary>
        public AzureVmUserUpdateTask SshKeyValue(string sshKeyValue = null)
        {
            WithArguments("--ssh-key-value");
            if (!string.IsNullOrEmpty(sshKeyValue))
            {
                 WithArguments(sshKeyValue);
            }

            return this;
        }
     }
}
