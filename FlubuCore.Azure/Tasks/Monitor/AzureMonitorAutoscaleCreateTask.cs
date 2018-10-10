
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorAutoscaleCreateTask : ExternalProcessTaskBase<AzureMonitorAutoscaleCreateTask>
     {
        
        /// <summary>
        /// Create new autoscale settings.
        /// </summary>
        public AzureMonitorAutoscaleCreateTask(string count = null ,  string resource = null)
        {
            WithArguments("az monitor autoscale create");
WithArguments("--count");
            if (!string.IsNullOrEmpty(count))
            {
                 WithArguments(count);
            }

WithArguments("--resource");
            if (!string.IsNullOrEmpty(resource))
            {
                 WithArguments(resource);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Create the autoscale settings in a disabled state.
        /// </summary>
        public AzureMonitorAutoscaleCreateTask Disabled(string disabled = null)
        {
            WithArguments("--disabled");
            if (!string.IsNullOrEmpty(disabled))
            {
                 WithArguments(disabled);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureMonitorAutoscaleCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Name of the autoscale settings.
        /// </summary>
        public AzureMonitorAutoscaleCreateTask Name(string name = null)
        {
            WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureMonitorAutoscaleCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// The maximum number of instances.
        /// </summary>
        public AzureMonitorAutoscaleCreateTask MaxCount(string maxCount = null)
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
        public AzureMonitorAutoscaleCreateTask MinCount(string minCount = null)
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
        public AzureMonitorAutoscaleCreateTask Action(string action = null)
        {
            WithArguments("--action");
            if (!string.IsNullOrEmpty(action))
            {
                 WithArguments(action);
            }

            return this;
        }

        /// <summary>
        /// Send email to subscription administrator on scaling.
        /// </summary>
        public AzureMonitorAutoscaleCreateTask EmailAdministrator(string emailAdministrator = null)
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
        public AzureMonitorAutoscaleCreateTask EmailCoadministrators(string emailCoadministrators = null)
        {
            WithArguments("--email-coadministrators");
            if (!string.IsNullOrEmpty(emailCoadministrators))
            {
                 WithArguments(emailCoadministrators);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureMonitorAutoscaleCreateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Target resource provider namespace.
        /// </summary>
        public AzureMonitorAutoscaleCreateTask ResourceNamespace(string resourceNamespace = null)
        {
            WithArguments("--resource-namespace");
            if (!string.IsNullOrEmpty(resourceNamespace))
            {
                 WithArguments(resourceNamespace);
            }

            return this;
        }

        /// <summary>
        /// Target resource parent path, if applicable.
        /// </summary>
        public AzureMonitorAutoscaleCreateTask ResourceParent(string resourceParent = null)
        {
            WithArguments("--resource-parent");
            if (!string.IsNullOrEmpty(resourceParent))
            {
                 WithArguments(resourceParent);
            }

            return this;
        }

        /// <summary>
        /// Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').
        /// </summary>
        public AzureMonitorAutoscaleCreateTask ResourceType(string resourceType = null)
        {
            WithArguments("--resource-type");
            if (!string.IsNullOrEmpty(resourceType))
            {
                 WithArguments(resourceType);
            }

            return this;
        }
     }
}
