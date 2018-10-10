
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventhubs
{
     public partial class AzureEventhubsNamespaceUpdateTask : ExternalProcessTaskBase<AzureEventhubsNamespaceUpdateTask>
     {
        
        /// <summary>
        /// Updates the Event Hubs Namespace.
        /// </summary>
        public AzureEventhubsNamespaceUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az eventhubs namespace update");
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
        public AzureEventhubsNamespaceUpdateTask Capacity(string capacity = null)
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
        public AzureEventhubsNamespaceUpdateTask EnableAutoInflate(string enableAutoInflate = null)
        {
            WithArguments("--enable-auto-inflate");
            if (!string.IsNullOrEmpty(enableAutoInflate))
            {
                 WithArguments(enableAutoInflate);
            }

            return this;
        }

        /// <summary>
        /// Upper limit of throughput units when AutoInflate is enabled, vaule should be within 0 to 20 throughput units. ( 0 if AutoInflateEnabled = true).
        /// </summary>
        public AzureEventhubsNamespaceUpdateTask MaximumThroughputUnits(string maximumThroughputUnits = null)
        {
            WithArguments("--maximum-throughput-units");
            if (!string.IsNullOrEmpty(maximumThroughputUnits))
            {
                 WithArguments(maximumThroughputUnits);
            }

            return this;
        }

        public AzureEventhubsNamespaceUpdateTask Sku(string sku = null)
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
        public AzureEventhubsNamespaceUpdateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureEventhubsNamespaceUpdateTask Add(string add = null)
        {
            WithArguments("--add");
            if (!string.IsNullOrEmpty(add))
            {
                 WithArguments(add);
            }

            return this;
        }

        /// <summary>
        /// When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.
        /// </summary>
        public AzureEventhubsNamespaceUpdateTask ForceString(string forceString = null)
        {
            WithArguments("--force-string");
            if (!string.IsNullOrEmpty(forceString))
            {
                 WithArguments(forceString);
            }

            return this;
        }

        /// <summary>
        /// Remove a property or an element from a list.  Example: --remove property.list <indexToRemove> OR --remove propertyToRemove.
        /// </summary>
        public AzureEventhubsNamespaceUpdateTask Remove(string remove = null)
        {
            WithArguments("--remove");
            if (!string.IsNullOrEmpty(remove))
            {
                 WithArguments(remove);
            }

            return this;
        }

        /// <summary>
        /// Update an object by specifying a property path and value to set.  Example: --set property1.property2=<value>.
        /// </summary>
        public AzureEventhubsNamespaceUpdateTask Set(string set = null)
        {
            WithArguments("--set");
            if (!string.IsNullOrEmpty(set))
            {
                 WithArguments(set);
            }

            return this;
        }
     }
}
