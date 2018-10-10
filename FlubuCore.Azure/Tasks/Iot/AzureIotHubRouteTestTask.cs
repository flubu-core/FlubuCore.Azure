
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotHubRouteTestTask : ExternalProcessTaskBase<AzureIotHubRouteTestTask>
     {
        
        /// <summary>
        /// Test all routes or mentioned route in IoT Hub.
        /// </summary>
        public AzureIotHubRouteTestTask(string hubName = null)
        {
            WithArguments("az iot hub route test");
WithArguments("--hub-name");
            if (!string.IsNullOrEmpty(hubName))
            {
                 WithArguments(hubName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// App properties of the route message.
        /// </summary>
        public AzureIotHubRouteTestTask Ap(string ap = null)
        {
            WithArguments("--ap");
            if (!string.IsNullOrEmpty(ap))
            {
                 WithArguments(ap);
            }

            return this;
        }

        /// <summary>
        /// Body of the route message.
        /// </summary>
        public AzureIotHubRouteTestTask Body(string body = null)
        {
            WithArguments("--body");
            if (!string.IsNullOrEmpty(body))
            {
                 WithArguments(body);
            }

            return this;
        }

        /// <summary>
        /// Name of the Route.
        /// </summary>
        public AzureIotHubRouteTestTask Name(string name = null)
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
        public AzureIotHubRouteTestTask ResourceGroup(string resourceGroup = null)
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
        public AzureIotHubRouteTestTask Source(string source = null)
        {
            WithArguments("--source");
            if (!string.IsNullOrEmpty(source))
            {
                 WithArguments(source);
            }

            return this;
        }

        /// <summary>
        /// System properties of the route message.
        /// </summary>
        public AzureIotHubRouteTestTask Sp(string sp = null)
        {
            WithArguments("--sp");
            if (!string.IsNullOrEmpty(sp))
            {
                 WithArguments(sp);
            }

            return this;
        }
     }
}
