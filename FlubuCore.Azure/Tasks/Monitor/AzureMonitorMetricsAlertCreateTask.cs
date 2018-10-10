
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorMetricsAlertCreateTask : ExternalProcessTaskBase<AzureMonitorMetricsAlertCreateTask>
     {
        
        /// <summary>
        /// Create an alert rule.
        /// </summary>
        public AzureMonitorMetricsAlertCreateTask(string condition = null ,  string name = null ,  string resourceGroup = null ,  string scopes = null)
        {
            WithArguments("az monitor metrics alert create");
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

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--scopes");
            if (!string.IsNullOrEmpty(scopes))
            {
                 WithArguments(scopes);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Add an action group and optional webhook properties to fire when the alert is triggered.
        /// </summary>
        public AzureMonitorMetricsAlertCreateTask Action(string action = null)
        {
            WithArguments("--action");
            if (!string.IsNullOrEmpty(action))
            {
                 WithArguments(action);
            }

            return this;
        }

        /// <summary>
        /// Automatically resolve the alert.
        /// </summary>
        public AzureMonitorMetricsAlertCreateTask AutoMitigate(string autoMitigate = null)
        {
            WithArguments("--auto-mitigate");
            if (!string.IsNullOrEmpty(autoMitigate))
            {
                 WithArguments(autoMitigate);
            }

            return this;
        }

        /// <summary>
        /// Create the rule in a disabled state.
        /// </summary>
        public AzureMonitorMetricsAlertCreateTask Disabled(string disabled = null)
        {
            WithArguments("--disabled");
            if (!string.IsNullOrEmpty(disabled))
            {
                 WithArguments(disabled);
            }

            return this;
        }

        /// <summary>
        /// Frequency with which to evaluate the rule in "##h##m##s" format.
        /// </summary>
        public AzureMonitorMetricsAlertCreateTask EvaluationFrequency(string evaluationFrequency = null)
        {
            WithArguments("--evaluation-frequency");
            if (!string.IsNullOrEmpty(evaluationFrequency))
            {
                 WithArguments(evaluationFrequency);
            }

            return this;
        }

        /// <summary>
        /// Severity of the alert from 0 (low) to 4 (high).
        /// </summary>
        public AzureMonitorMetricsAlertCreateTask Severity(string severity = null)
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
        public AzureMonitorMetricsAlertCreateTask Tags(string tags = null)
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
        public AzureMonitorMetricsAlertCreateTask WindowSize(string windowSize = null)
        {
            WithArguments("--window-size");
            if (!string.IsNullOrEmpty(windowSize))
            {
                 WithArguments(windowSize);
            }

            return this;
        }
     }
}
