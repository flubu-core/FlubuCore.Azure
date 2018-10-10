
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorAlertCreateTask : ExternalProcessTaskBase<AzureMonitorAlertCreateTask>
     {
        
        /// <summary>
        /// Create a metric-based alert rule.
        /// </summary>
        public AzureMonitorAlertCreateTask(string condition = null ,  string name = null ,  string target = null)
        {
            WithArguments("az monitor alert create");
WithArguments("--condition");
            if (!string.IsNullOrEmpty(condition))
            {
                 WithArguments(condition);
            }

WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--target");
            if (!string.IsNullOrEmpty(target))
            {
                 WithArguments(target);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Create the rule in a disabled state.
        /// </summary>
        public AzureMonitorAlertCreateTask Disabled(string disabled = null)
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
        public AzureMonitorAlertCreateTask Location(string location = null)
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
        public AzureMonitorAlertCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Add an action to fire when the alert is triggered.
        /// </summary>
        public AzureMonitorAlertCreateTask Action(string action = null)
        {
            WithArguments("--action");
            if (!string.IsNullOrEmpty(action))
            {
                 WithArguments(action);
            }

            return this;
        }

        /// <summary>
        /// Email the service owners if an alert is triggered.
        /// </summary>
        public AzureMonitorAlertCreateTask EmailServiceOwners(string emailServiceOwners = null)
        {
            WithArguments("--email-service-owners");
            if (!string.IsNullOrEmpty(emailServiceOwners))
            {
                 WithArguments(emailServiceOwners);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureMonitorAlertCreateTask ResourceGroup(string resourceGroup = null)
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
        public AzureMonitorAlertCreateTask TargetNamespace(string targetNamespace = null)
        {
            WithArguments("--target-namespace");
            if (!string.IsNullOrEmpty(targetNamespace))
            {
                 WithArguments(targetNamespace);
            }

            return this;
        }

        /// <summary>
        /// Target resource parent path, if applicable.
        /// </summary>
        public AzureMonitorAlertCreateTask TargetParent(string targetParent = null)
        {
            WithArguments("--target-parent");
            if (!string.IsNullOrEmpty(targetParent))
            {
                 WithArguments(targetParent);
            }

            return this;
        }

        /// <summary>
        /// Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').
        /// </summary>
        public AzureMonitorAlertCreateTask TargetType(string targetType = null)
        {
            WithArguments("--target-type");
            if (!string.IsNullOrEmpty(targetType))
            {
                 WithArguments(targetType);
            }

            return this;
        }
     }
}
