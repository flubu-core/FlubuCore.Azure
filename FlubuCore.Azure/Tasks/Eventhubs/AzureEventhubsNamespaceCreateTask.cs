
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventhubs
{
     public partial class AzureEventhubsNamespaceCreateTask : ExternalProcessTaskBase<AzureEventhubsNamespaceCreateTask>
     {
        
        /// <summary>
        /// Creates the Event Hubs Namespace.
        /// </summary>
        public AzureEventhubsNamespaceCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az eventhubs namespace create");
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

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Capacity for Sku.
        /// </summary>
        public AzureEventhubsNamespaceCreateTask Capacity(string capacity = null)
        {
            WithArguments("--capacity");
            if (!string.IsNullOrEmpty(capacity))
            {
                 WithArguments(capacity);
            }

            return this;
        }

        /// <summary>
        /// A boolean value that indicates whether AutoInflate is enabled for eventhub namespace.
        /// </summary>
        public AzureEventhubsNamespaceCreateTask EnableAutoInflate(string enableAutoInflate = null)
        {
            WithArguments("--enable-auto-inflate");
            if (!string.IsNullOrEmpty(enableAutoInflate))
            {
                 WithArguments(enableAutoInflate);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureEventhubsNamespaceCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Upper limit of throughput units when AutoInflate is enabled, vaule should be within 0 to 20 throughput units. ( 0 if AutoInflateEnabled = true).
        /// </summary>
        public AzureEventhubsNamespaceCreateTask MaximumThroughputUnits(string maximumThroughputUnits = null)
        {
            WithArguments("--maximum-throughput-units");
            if (!string.IsNullOrEmpty(maximumThroughputUnits))
            {
                 WithArguments(maximumThroughputUnits);
            }

            return this;
        }

        public AzureEventhubsNamespaceCreateTask Sku(string sku = null)
        {
            WithArguments("--sku");
            if (!string.IsNullOrEmpty(sku))
            {
                 WithArguments(sku);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureEventhubsNamespaceCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }
     }
}
