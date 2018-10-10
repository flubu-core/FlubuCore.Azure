
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Signalr
{
     public partial class AzureSignalrCreateTask : ExternalProcessTaskBase<AzureSignalrCreateTask>
     {
        
        /// <summary>
        /// Creates a SignalR Service.
        /// </summary>
        public AzureSignalrCreateTask(string name = null ,  string resourceGroup = null ,  string sku = null)
        {
            WithArguments("az signalr create");
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

WithArguments("--sku");
            if (!string.IsNullOrEmpty(sku))
            {
                 WithArguments(sku);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureSignalrCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureSignalrCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// The number of signalr service unit count.
        /// </summary>
        public AzureSignalrCreateTask UnitCount(string unitCount = null)
        {
            WithArguments("--unit-count");
            if (!string.IsNullOrEmpty(unitCount))
            {
                 WithArguments(unitCount);
            }

            return this;
        }
     }
}
