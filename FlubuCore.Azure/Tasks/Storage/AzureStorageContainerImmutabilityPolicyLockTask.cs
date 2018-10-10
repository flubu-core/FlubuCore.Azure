
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageContainerImmutabilityPolicyLockTask : ExternalProcessTaskBase<AzureStorageContainerImmutabilityPolicyLockTask>
     {
        
        /// <summary>
        /// Sets the ImmutabilityPolicy to Locked state.
        /// </summary>
        public AzureStorageContainerImmutabilityPolicyLockTask(string accountName = null ,  string containerName = null ,  string ifMatch = null)
        {
            WithArguments("az storage container immutability-policy lock");
WithArguments("--account-name");
            if (!string.IsNullOrEmpty(accountName))
            {
                 WithArguments(accountName);
            }

WithArguments("--container-name");
            if (!string.IsNullOrEmpty(containerName))
            {
                 WithArguments(containerName);
            }

WithArguments("--if-match");
            if (!string.IsNullOrEmpty(ifMatch))
            {
                 WithArguments(ifMatch);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureStorageContainerImmutabilityPolicyLockTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }
     }
}
