
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorActionGroupUpdateTask : ExternalProcessTaskBase<AzureMonitorActionGroupUpdateTask>
     {
        
        /// <summary>
        /// Update an action group.
        /// </summary>
        public AzureMonitorActionGroupUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az monitor action-group update");
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
        /// Update the group short name of the action group.
        /// </summary>
        public AzureMonitorActionGroupUpdateTask ShortName(string shortName = null)
        {
            WithArguments("--short-name");
            if (!string.IsNullOrEmpty(shortName))
            {
                 WithArguments(shortName);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureMonitorActionGroupUpdateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Add receivers to the action group.
        /// </summary>
        public AzureMonitorActionGroupUpdateTask AddAction(string addAction = null)
        {
            WithArguments("--add-action");
            if (!string.IsNullOrEmpty(addAction))
            {
                 WithArguments(addAction);
            }

            return this;
        }

        /// <summary>
        /// Remove receivers from the action group. Accept space-separated list of receiver names.
        /// </summary>
        public AzureMonitorActionGroupUpdateTask RemoveAction(string removeAction = null)
        {
            WithArguments("--remove-action");
            if (!string.IsNullOrEmpty(removeAction))
            {
                 WithArguments(removeAction);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureMonitorActionGroupUpdateTask Add(string add = null)
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
        public AzureMonitorActionGroupUpdateTask ForceString(string forceString = null)
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
        public AzureMonitorActionGroupUpdateTask Remove(string remove = null)
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
        public AzureMonitorActionGroupUpdateTask Set(string set = null)
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
