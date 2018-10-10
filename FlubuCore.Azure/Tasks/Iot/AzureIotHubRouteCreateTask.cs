
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubRouteCreateTask : ExternalProcessTaskBase<AzureIotHubRouteCreateTask>
     {
        
        /// <summary>
        /// Create a route in IoT Hub.
        /// </summary>
        public AzureIotHubRouteCreateTask(string en = null ,  string hubName = null ,  string name = null ,  string source = null)
        {
            WithArguments("az iot hub route create");
WithArguments("--en");
            if (!string.IsNullOrEmpty(en))
            {
                 WithArguments(en);
            }

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

WithArguments("--source");
            if (!string.IsNullOrEmpty(source))
            {
                 WithArguments(source);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Condition that is evaluated to apply the routing rule.
        /// </summary>
        public AzureIotHubRouteCreateTask Condition(string condition = null)
        {
            WithArguments("--condition");
            if (!string.IsNullOrEmpty(condition))
            {
                 WithArguments(condition);
            }

            return this;
        }

        /// <summary>
        /// A boolean indicating whether to enable route to the Iot hub.
        /// </summary>
        public AzureIotHubRouteCreateTask Enabled(string enabled = null)
        {
            WithArguments("--enabled");
            if (!string.IsNullOrEmpty(enabled))
            {
                 WithArguments(enabled);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureIotHubRouteCreateTask ResourceGroup(string resourceGroup = null)
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
