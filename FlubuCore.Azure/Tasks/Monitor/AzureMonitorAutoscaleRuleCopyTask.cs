
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorAutoscaleRuleCopyTask : ExternalProcessTaskBase<AzureMonitorAutoscaleRuleCopyTask>
     {
        
        /// <summary>
        /// Copy autoscale rules from one profile to another.
        /// </summary>
        public AzureMonitorAutoscaleRuleCopyTask(string autoscaleName = null ,  string destSchedule = null ,  string index = null ,  string resourceGroup = null)
        {
            WithArguments("az monitor autoscale rule copy");
WithArguments("--autoscale-name");
            if (!string.IsNullOrEmpty(autoscaleName))
            {
                 WithArguments(autoscaleName);
            }

WithArguments("--dest-schedule");
            if (!string.IsNullOrEmpty(destSchedule))
            {
                 WithArguments(destSchedule);
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
        /// Name of the profile to copy rules from.
        /// </summary>
        public AzureMonitorAutoscaleRuleCopyTask SourceSchedule(string sourceSchedule = null)
        {
            WithArguments("--source-schedule");
            if (!string.IsNullOrEmpty(sourceSchedule))
            {
                 WithArguments(sourceSchedule);
            }

            return this;
        }
     }
}
