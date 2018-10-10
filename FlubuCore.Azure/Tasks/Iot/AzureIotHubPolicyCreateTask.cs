
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubPolicyCreateTask : ExternalProcessTaskBase<AzureIotHubPolicyCreateTask>
     {
        
        /// <summary>
        /// Create a new shared access policy in an IoT hub.
        /// </summary>
        public AzureIotHubPolicyCreateTask(string hubName = null ,  string name = null ,  string permissions = null)
        {
            WithArguments("az iot hub policy create");
WithArguments("--hub-name");
            if (!string.IsNullOrEmpty(hubName))
            {
                 WithArguments(hubName);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--permissions");
            if (!string.IsNullOrEmpty(permissions))
            {
                 WithArguments(permissions);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureIotHubPolicyCreateTask ResourceGroup(string resourceGroup = null)
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
