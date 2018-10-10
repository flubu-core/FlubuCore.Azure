
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDpsAccessPolicyUpdateTask : ExternalProcessTaskBase<AzureIotDpsAccessPolicyUpdateTask>
     {
        
        /// <summary>
        /// Update a shared access policy in an Azure IoT Hub device provisioning service.
        /// </summary>
        public AzureIotDpsAccessPolicyUpdateTask(string accessPolicyName = null ,  string dpsName = null ,  string resourceGroup = null)
        {
            WithArguments("az iot dps access-policy update");
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

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureIotDpsAccessPolicyUpdateTask NoWait(string noWait = null)
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
        public AzureIotDpsAccessPolicyUpdateTask PrimaryKey(string primaryKey = null)
        {
            WithArguments("--primary-key");
            if (!string.IsNullOrEmpty(primaryKey))
            {
                 WithArguments(primaryKey);
            }

            return this;
        }

        /// <summary>
        /// Access rights for the IoT provisioning service. Use space-separated list for multiple rights.
        /// </summary>
        public AzureIotDpsAccessPolicyUpdateTask Rights(string rights = null)
        {
            WithArguments("--rights");
            if (!string.IsNullOrEmpty(rights))
            {
                 WithArguments(rights);
            }

            return this;
        }

        /// <summary>
        /// Secondary SAS key value.
        /// </summary>
        public AzureIotDpsAccessPolicyUpdateTask SecondaryKey(string secondaryKey = null)
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
