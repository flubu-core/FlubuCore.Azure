
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorAutoscaleUpdateTask : ExternalProcessTaskBase<AzureMonitorAutoscaleUpdateTask>
     {
        
        /// <summary>
        /// Update autoscale settings.
        /// </summary>
        public AzureMonitorAutoscaleUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az monitor autoscale update");
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
        /// Autoscale settings enabled status.
        /// </summary>
        public AzureMonitorAutoscaleUpdateTask Enabled(string enabled = null)
        {
            WithArguments("--enabled");
            if (!string.IsNullOrEmpty(enabled))
            {
                 WithArguments(enabled);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureMonitorAutoscaleUpdateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// The numer of instances to use. If used with --min/max-count, the default number of instances to use.
        /// </summary>
        public AzureMonitorAutoscaleUpdateTask Count(string count = null)
        {
            WithArguments("--count");
            if (!string.IsNullOrEmpty(count))
            {
                 WithArguments(count);
            }

            return this;
        }

        /// <summary>
        /// The maximum number of instances.
        /// </summary>
        public AzureMonitorAutoscaleUpdateTask MaxCount(string maxCount = null)
        {
            WithArguments("--max-count");
            if (!string.IsNullOrEmpty(maxCount))
            {
                 WithArguments(maxCount);
            }

            return this;
        }

        /// <summary>
        /// The minimum number of instances.
        /// </summary>
        public AzureMonitorAutoscaleUpdateTask MinCount(string minCount = null)
        {
            WithArguments("--min-count");
            if (!string.IsNullOrEmpty(minCount))
            {
                 WithArguments(minCount);
            }

            return this;
        }

        /// <summary>
        /// Add an action to fire when a scaling event occurs.
        /// </summary>
        public AzureMonitorAutoscaleUpdateTask AddAction(string addAction = null)
        {
            WithArguments("--add-action");
            if (!string.IsNullOrEmpty(addAction))
            {
                 WithArguments(addAction);
            }

            return this;
        }

        /// <summary>
        /// Send email to subscription administrator on scaling.
        /// </summary>
        public AzureMonitorAutoscaleUpdateTask EmailAdministrator(string emailAdministrator = null)
        {
            WithArguments("--email-administrator");
            if (!string.IsNullOrEmpty(emailAdministrator))
            {
                 WithArguments(emailAdministrator);
            }

            return this;
        }

        /// <summary>
        /// Send email to subscription co-administrators on scaling.
        /// </summary>
        public AzureMonitorAutoscaleUpdateTask EmailCoadministrators(string emailCoadministrators = null)
        {
            WithArguments("--email-coadministrators");
            if (!string.IsNullOrEmpty(emailCoadministrators))
            {
                 WithArguments(emailCoadministrators);
            }

            return this;
        }

        /// <summary>
        /// Remove one or more actions.
        /// </summary>
        public AzureMonitorAutoscaleUpdateTask RemoveAction(string removeAction = null)
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
        public AzureMonitorAutoscaleUpdateTask Add(string add = null)
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
        public AzureMonitorAutoscaleUpdateTask ForceString(string forceString = null)
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
        public AzureMonitorAutoscaleUpdateTask Remove(string remove = null)
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
        public AzureMonitorAutoscaleUpdateTask Set(string set = null)
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
