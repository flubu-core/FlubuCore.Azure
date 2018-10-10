
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageContainerImmutabilityPolicyCreateTask : ExternalProcessTaskBase<AzureStorageContainerImmutabilityPolicyCreateTask>
     {
        
        /// <summary>
        /// Creates or updates an unlocked immutability policy.
        /// </summary>
        public AzureStorageContainerImmutabilityPolicyCreateTask(string accountName = null ,  string containerName = null ,  string period = null)
        {
            WithArguments("az storage container immutability-policy create");
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

WithArguments("--period");
            if (!string.IsNullOrEmpty(period))
            {
                 WithArguments(period);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureStorageContainerImmutabilityPolicyCreateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// The entity state (ETag) version of the immutability policy to update. A value of "*" can be used to apply the operation only if the immutability policy already exists. If omitted, this operation will always be applied.
        /// </summary>
        public AzureStorageContainerImmutabilityPolicyCreateTask IfMatch(string ifMatch = null)
        {
            WithArguments("--if-match");
            if (!string.IsNullOrEmpty(ifMatch))
            {
                 WithArguments(ifMatch);
            }

            return this;
        }
     }
}
