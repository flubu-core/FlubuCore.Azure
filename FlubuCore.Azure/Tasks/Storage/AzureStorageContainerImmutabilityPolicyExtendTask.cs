
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Storage
{
     public partial class AzureStorageContainerImmutabilityPolicyExtendTask : ExternalProcessTaskBase<AzureStorageContainerImmutabilityPolicyExtendTask>
     {
        
        /// <summary>
        /// Extends the immutabilityPeriodSinceCreationInDays of a locked immutabilityPolicy.
        /// </summary>
        public AzureStorageContainerImmutabilityPolicyExtendTask(string accountName = null ,  string containerName = null ,  string period = null ,  string ifMatch = null)
        {
            WithArguments("az storage container immutability-policy extend");
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
        public AzureStorageContainerImmutabilityPolicyExtendTask ResourceGroup(string resourceGroup = null)
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
