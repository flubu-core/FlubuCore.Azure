
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDpsAccessPolicyCreateTask : ExternalProcessTaskBase<AzureIotDpsAccessPolicyCreateTask>
     {
        
        /// <summary>
        /// Create a new shared access policy in an Azure IoT Hub device provisioning service.
        /// </summary>
        public AzureIotDpsAccessPolicyCreateTask(string accessPolicyName = null ,  string dpsName = null ,  string resourceGroup = null ,  string rights = null)
        {
            WithArguments("az iot dps access-policy create");
WithArguments("--access-policy-name");
            if (!string.IsNullOrEmpty(accessPolicyName))
            {
                 WithArguments(accessPolicyName);
            }

WithArguments("--dps-name");
            if (!string.IsNullOrEmpty(dpsName))
            {
                 WithArguments(dpsName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--rights");
            if (!string.IsNullOrEmpty(rights))
            {
                 WithArguments(rights);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureIotDpsAccessPolicyCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Primary SAS key value.
        /// </summary>
        public AzureIotDpsAccessPolicyCreateTask PrimaryKey(string primaryKey = null)
        {
            WithArguments("--primary-key");
            if (!string.IsNullOrEmpty(primaryKey))
            {
                 WithArguments(primaryKey);
            }

            return this;
        }

        /// <summary>
        /// Secondary SAS key value.
        /// </summary>
        public AzureIotDpsAccessPolicyCreateTask SecondaryKey(string secondaryKey = null)
        {
            WithArguments("--secondary-key");
            if (!string.IsNullOrEmpty(secondaryKey))
            {
                 WithArguments(secondaryKey);
            }

            return this;
        }
     }
}
