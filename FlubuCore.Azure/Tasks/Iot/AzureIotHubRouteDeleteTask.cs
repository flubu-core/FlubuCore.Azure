
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubRouteDeleteTask : ExternalProcessTaskBase<AzureIotHubRouteDeleteTask>
     {
        
        /// <summary>
        /// Delete all or mentioned route for your IoT Hub.
        /// </summary>
        public AzureIotHubRouteDeleteTask(string hubName = null)
        {
            WithArguments("az iot hub route delete");
WithArguments("--hub-name");
            if (!string.IsNullOrEmpty(hubName))
            {
                 WithArguments(hubName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of the Route.
        /// </summary>
        public AzureIotHubRouteDeleteTask Name(string name = null)
        {
            WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureIotHubRouteDeleteTask ResourceGroup(string resourceGroup = null)
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
        public AzureIotHubRouteDeleteTask Source(string source = null)
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
