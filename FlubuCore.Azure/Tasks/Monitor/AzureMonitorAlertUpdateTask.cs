
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorAlertUpdateTask : ExternalProcessTaskBase<AzureMonitorAlertUpdateTask>
     {
        
        /// <summary>
        /// Update a metric-based alert rule.
        /// </summary>
        public AzureMonitorAlertUpdateTask(string name = null)
        {
            WithArguments("az monitor alert update");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

        }

        protected override string Description { get; set; }
        
        public AzureMonitorAlertUpdateTask Enabled(string enabled = null)
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
        public AzureMonitorAlertUpdateTask Tags(string tags = null)
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
        public AzureMonitorAlertUpdateTask AddAction(string addAction = null)
        {
            WithArguments("--add-action");
            if (!string.IsNullOrEmpty(addAction))
            {
                 WithArguments(addAction);
            }

            return this;
        }

        /// <summary>
        /// Email the service owners if an alert is triggered.
        /// </summary>
        public AzureMonitorAlertUpdateTask EmailServiceOwners(string emailServiceOwners = null)
        {
            WithArguments("--email-service-owners");
            if (!string.IsNullOrEmpty(emailServiceOwners))
            {
                 WithArguments(emailServiceOwners);
            }

            return this;
        }

        /// <summary>
        /// Remove one or more actions.
        /// </summary>
        public AzureMonitorAlertUpdateTask RemoveAction(string removeAction = null)
        {
            WithArguments("--remove-action");
            if (!string.IsNullOrEmpty(removeAction))
            {
                 WithArguments(removeAction);
            }

            return this;
        }

        /// <summary>
        /// Type of aggregation to apply based on --period.
        /// </summary>
        public AzureMonitorAlertUpdateTask Aggregation(string aggregation = null)
        {
            WithArguments("--aggregation");
            if (!string.IsNullOrEmpty(aggregation))
            {
                 WithArguments(aggregation);
            }

            return this;
        }

        /// <summary>
        /// The condition which triggers the rule.
        /// </summary>
        public AzureMonitorAlertUpdateTask Condition(string condition = null)
        {
            WithArguments("--condition");
            if (!string.IsNullOrEmpty(condition))
            {
                 WithArguments(condition);
            }

            return this;
        }

        /// <summary>
        /// Name of the metric to base the rule on.
        /// </summary>
        public AzureMonitorAlertUpdateTask Metric(string metric = null)
        {
            WithArguments("--metric");
            if (!string.IsNullOrEmpty(metric))
            {
                 WithArguments(metric);
            }

            return this;
        }

        /// <summary>
        /// How to compare the metric against the threshold.
        /// </summary>
        public AzureMonitorAlertUpdateTask Operator(string @operator = null)
        {
            WithArguments("--operator");
            if (!string.IsNullOrEmpty(@operator))
            {
                 WithArguments(@operator);
            }

            return this;
        }

        /// <summary>
        /// Time span over which to apply --aggregation, in nDnHnMnS shorthand or full ISO8601 format.
        /// </summary>
        public AzureMonitorAlertUpdateTask Period(string period = null)
        {
            WithArguments("--period");
            if (!string.IsNullOrEmpty(period))
            {
                 WithArguments(period);
            }

            return this;
        }

        /// <summary>
        /// Numeric threshold at which to trigger the alert.
        /// </summary>
        public AzureMonitorAlertUpdateTask Threshold(string threshold = null)
        {
            WithArguments("--threshold");
            if (!string.IsNullOrEmpty(threshold))
            {
                 WithArguments(threshold);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of the target resource.
        /// </summary>
        public AzureMonitorAlertUpdateTask Resource(string resource = null)
        {
            WithArguments("--resource");
            if (!string.IsNullOrEmpty(resource))
            {
                 WithArguments(resource);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureMonitorAlertUpdateTask ResourceGroup(string resourceGroup = null)
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
        public AzureMonitorAlertUpdateTask ResourceNamespace(string resourceNamespace = null)
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
        public AzureMonitorAlertUpdateTask ResourceParent(string resourceParent = null)
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
        public AzureMonitorAlertUpdateTask ResourceType(string resourceType = null)
        {
            WithArguments("--resource-type");
            if (!string.IsNullOrEmpty(resourceType))
            {
                 WithArguments(resourceType);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureMonitorAlertUpdateTask Add(string add = null)
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
        public AzureMonitorAlertUpdateTask ForceString(string forceString = null)
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
        public AzureMonitorAlertUpdateTask Remove(string remove = null)
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
        public AzureMonitorAlertUpdateTask Set(string set = null)
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
