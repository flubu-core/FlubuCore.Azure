
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Redis
{
     public partial class AzureRedisUpdateTask : ExternalProcessTaskBase<AzureRedisUpdateTask>
     {
        
        /// <summary>
        /// Scale or update settings of a Redis cache.
        /// </summary>
        public AzureRedisUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az redis update");
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
        /// Type of Redis cache.
        /// </summary>
        public AzureRedisUpdateTask Sku(string sku = null)
        {
            WithArguments("--sku");
            if (!string.IsNullOrEmpty(sku))
            {
                 WithArguments(sku);
            }

            return this;
        }

        /// <summary>
        /// Size of Redis cache to deploy. Example : values for C family (C0, C1, C2, C3, C4, C5, C6). For P family (P1, P2, P3, P4).
        /// </summary>
        public AzureRedisUpdateTask VmSize(string vmSize = null)
        {
            WithArguments("--vm-size");
            if (!string.IsNullOrEmpty(vmSize))
            {
                 WithArguments(vmSize);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureRedisUpdateTask Add(string add = null)
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
        public AzureRedisUpdateTask ForceString(string forceString = null)
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
        public AzureRedisUpdateTask Remove(string remove = null)
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
        public AzureRedisUpdateTask Set(string set = null)
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
