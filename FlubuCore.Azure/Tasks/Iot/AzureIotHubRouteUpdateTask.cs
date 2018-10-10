
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubRouteUpdateTask : ExternalProcessTaskBase<AzureIotHubRouteUpdateTask>
     {
        
        /// <summary>
        /// Update a route in IoT Hub.
        /// </summary>
        public AzureIotHubRouteUpdateTask(string hubName = null ,  string name = null)
        {
            WithArguments("az iot hub route update");
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

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Condition that is evaluated to apply the routing rule.
        /// </summary>
        public AzureIotHubRouteUpdateTask Condition(string condition = null)
        {
            WithArguments("--condition");
            if (!string.IsNullOrEmpty(condition))
            {
                 WithArguments(condition);
            }

            return this;
        }

        /// <summary>
        /// Name of the routing endpoint.
        /// </summary>
        public AzureIotHubRouteUpdateTask En(string en = null)
        {
            WithArguments("--en");
            if (!string.IsNullOrEmpty(en))
            {
                 WithArguments(en);
            }

            return this;
        }

        /// <summary>
        /// A boolean indicating whether to enable route to the Iot hub.
        /// </summary>
        public AzureIotHubRouteUpdateTask Enabled(string enabled = null)
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
        public AzureIotHubRouteUpdateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Source of the route.
        /// </summary>
        public AzureIotHubRouteUpdateTask Source(string source = null)
        {
            WithArguments("--source");
            if (!string.IsNullOrEmpty(source))
            {
                 WithArguments(source);
            }

            return this;
        }
     }
}
