
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorAutoscaleRuleCreateTask : ExternalProcessTaskBase<AzureMonitorAutoscaleRuleCreateTask>
     {
        
        /// <summary>
        /// Add a new autoscale rule.
        /// </summary>
        public AzureMonitorAutoscaleRuleCreateTask(string autoscaleName = null ,  string condition = null ,  string scale = null)
        {
            WithArguments("az monitor autoscale rule create");
WithArguments("--autoscale-name");
            if (!string.IsNullOrEmpty(autoscaleName))
            {
                 WithArguments(autoscaleName);
            }

WithArguments("--condition");
            if (!string.IsNullOrEmpty(condition))
            {
                 WithArguments(condition);
            }

WithArguments("--scale");
            if (!string.IsNullOrEmpty(scale))
            {
                 WithArguments(scale);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The number of minutes that must elapse before another scaling event can occur.
        /// </summary>
        public AzureMonitorAutoscaleRuleCreateTask Cooldown(string cooldown = null)
        {
            WithArguments("--cooldown");
            if (!string.IsNullOrEmpty(cooldown))
            {
                 WithArguments(cooldown);
            }

            return this;
        }

        /// <summary>
        /// Name of the autoscale profile.
        /// </summary>
        public AzureMonitorAutoscaleRuleCreateTask ProfileName(string profileName = null)
        {
            WithArguments("--profile-name");
            if (!string.IsNullOrEmpty(profileName))
            {
                 WithArguments(profileName);
            }

            return this;
        }

        /// <summary>
        /// The way metrics are polled across instances.
        /// </summary>
        public AzureMonitorAutoscaleRuleCreateTask Timegrain(string timegrain = null)
        {
            WithArguments("--timegrain");
            if (!string.IsNullOrEmpty(timegrain))
            {
                 WithArguments(timegrain);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of the target resource.
        /// </summary>
        public AzureMonitorAutoscaleRuleCreateTask Resource(string resource = null)
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
        public AzureMonitorAutoscaleRuleCreateTask ResourceGroup(string resourceGroup = null)
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
        public AzureMonitorAutoscaleRuleCreateTask ResourceNamespace(string resourceNamespace = null)
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
        public AzureMonitorAutoscaleRuleCreateTask ResourceParent(string resourceParent = null)
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
        public AzureMonitorAutoscaleRuleCreateTask ResourceType(string resourceType = null)
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
