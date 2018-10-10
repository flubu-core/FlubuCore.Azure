
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iotcentral
{
     public partial class AzureIotcentralAppCreateTask : ExternalProcessTaskBase<AzureIotcentralAppCreateTask>
     {
        
        /// <summary>
        /// Create an IoT Central application.
        /// </summary>
        public AzureIotcentralAppCreateTask(string name = null ,  string resourceGroup = null ,  string subdomain = null)
        {
            WithArguments("az iotcentral app create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--subdomain");
            if (!string.IsNullOrEmpty(subdomain))
            {
                 WithArguments(subdomain);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Location of your IoT Central application. Default is the location of target resource group.
        /// </summary>
        public AzureIotcentralAppCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Pricing tier for IoT Central applications. Default value is F1, which is free.
        /// </summary>
        public AzureIotcentralAppCreateTask Sku(string sku = null)
        {
            WithArguments("--sku");
            if (!string.IsNullOrEmpty(sku))
            {
                 WithArguments(sku);
            }

            return this;
        }
     }
}
