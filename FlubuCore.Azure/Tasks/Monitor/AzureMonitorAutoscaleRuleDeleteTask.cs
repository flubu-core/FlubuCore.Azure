
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorAutoscaleRuleDeleteTask : ExternalProcessTaskBase<AzureMonitorAutoscaleRuleDeleteTask>
     {
        
        /// <summary>
        /// Remove autoscale rules from a profile.
        /// </summary>
        public AzureMonitorAutoscaleRuleDeleteTask(string autoscaleName = null ,  string index = null ,  string resourceGroup = null)
        {
            WithArguments("az monitor autoscale rule delete");
WithArguments("--autoscale-name");
            if (!string.IsNullOrEmpty(autoscaleName))
            {
                 WithArguments(autoscaleName);
            }

WithArguments("--index");
            if (!string.IsNullOrEmpty(index))
            {
                 WithArguments(index);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of the autoscale profile.
        /// </summary>
        public AzureMonitorAutoscaleRuleDeleteTask ProfileName(string profileName = null)
        {
            WithArguments("--profile-name");
            if (!string.IsNullOrEmpty(profileName))
            {
                 WithArguments(profileName);
            }

            return this;
        }
     }
}
