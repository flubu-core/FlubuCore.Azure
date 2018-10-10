
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorMetricsAlertUpdateTask : ExternalProcessTaskBase<AzureMonitorMetricsAlertUpdateTask>
     {
        
        /// <summary>
        /// Update an alert rule.
        /// </summary>
        public AzureMonitorMetricsAlertUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az monitor metrics alert update");
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
        /// Automatically resolve the alert.
        /// </summary>
        public AzureMonitorMetricsAlertUpdateTask AutoMitigate(string autoMitigate = null)
        {
            WithArguments("--auto-mitigate");
            if (!string.IsNullOrEmpty(autoMitigate))
            {
                 WithArguments(autoMitigate);
            }

            return this;
        }

        /// <summary>
        /// Whether the metric alert rule is enabled.
        /// </summary>
        public AzureMonitorMetricsAlertUpdateTask Enabled(string enabled = null)
        {
            WithArguments("--enabled");
            if (!string.IsNullOrEmpty(enabled))
            {
                 WithArguments(enabled);
            }

            return this;
        }

        /// <summary>
        /// Frequency with which to evaluate the rule in "##h##m##s" format.
        /// </summary>
        public AzureMonitorMetricsAlertUpdateTask EvaluationFrequency(string evaluationFrequency = null)
        {
            WithArguments("--evaluation-frequency");
            if (!string.IsNullOrEmpty(evaluationFrequency))
            {
                 WithArguments(evaluationFrequency);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of scopes the rule applies to.
        /// </summary>
        public AzureMonitorMetricsAlertUpdateTask Scopes(string scopes = null)
        {
            WithArguments("--scopes");
            if (!string.IsNullOrEmpty(scopes))
            {
                 WithArguments(scopes);
            }

            return this;
        }

        /// <summary>
        /// Severity of the alert from 0 (low) to 4 (high).
        /// </summary>
        public AzureMonitorMetricsAlertUpdateTask Severity(string severity = null)
        {
            WithArguments("--severity");
            if (!string.IsNullOrEmpty(severity))
            {
                 WithArguments(severity);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureMonitorMetricsAlertUpdateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Time over which to aggregate metrics in "##h##m##s" format.
        /// </summary>
        public AzureMonitorMetricsAlertUpdateTask WindowSize(string windowSize = null)
        {
            WithArguments("--window-size");
            if (!string.IsNullOrEmpty(windowSize))
            {
                 WithArguments(windowSize);
            }

            return this;
        }

        /// <summary>
        /// Add an action group and optional webhook properties to fire when the alert is triggered.
        /// </summary>
        public AzureMonitorMetricsAlertUpdateTask AddAction(string addAction = null)
        {
            WithArguments("--add-action");
            if (!string.IsNullOrEmpty(addAction))
            {
                 WithArguments(addAction);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of action group names to remove.
        /// </summary>
        public AzureMonitorMetricsAlertUpdateTask RemoveActions(string removeActions = null)
        {
            WithArguments("--remove-actions");
            if (!string.IsNullOrEmpty(removeActions))
            {
                 WithArguments(removeActions);
            }

            return this;
        }

        /// <summary>
        /// Add a condition which triggers the rule.
        /// </summary>
        public AzureMonitorMetricsAlertUpdateTask AddCondition(string addCondition = null)
        {
            WithArguments("--add-condition");
            if (!string.IsNullOrEmpty(addCondition))
            {
                 WithArguments(addCondition);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of condition names to remove.
        /// </summary>
        public AzureMonitorMetricsAlertUpdateTask RemoveConditions(string removeConditions = null)
        {
            WithArguments("--remove-conditions");
            if (!string.IsNullOrEmpty(removeConditions))
            {
                 WithArguments(removeConditions);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureMonitorMetricsAlertUpdateTask Add(string add = null)
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
        public AzureMonitorMetricsAlertUpdateTask ForceString(string forceString = null)
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
        public AzureMonitorMetricsAlertUpdateTask Remove(string remove = null)
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
        public AzureMonitorMetricsAlertUpdateTask Set(string set = null)
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
