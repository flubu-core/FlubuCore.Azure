
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorAutoscaleProfileCreateTask : ExternalProcessTaskBase<AzureMonitorAutoscaleProfileCreateTask>
     {
        
        /// <summary>
        /// Create a fixed or recurring autoscale profile.
        /// </summary>
        public AzureMonitorAutoscaleProfileCreateTask(string autoscaleName = null ,  string name = null ,  string resourceGroup = null ,  string count = null ,  string timezone = null)
        {
            WithArguments("az monitor autoscale profile create");
WithArguments("--autoscale-name");
            if (!string.IsNullOrEmpty(autoscaleName))
            {
                 WithArguments(autoscaleName);
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

WithArguments("--count");
            if (!string.IsNullOrEmpty(count))
            {
                 WithArguments(count);
            }

WithArguments("--timezone");
            if (!string.IsNullOrEmpty(timezone))
            {
                 WithArguments(timezone);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of an existing schedule from which to copy the scaling rules for the new schedule.
        /// </summary>
        public AzureMonitorAutoscaleProfileCreateTask CopyRules(string copyRules = null)
        {
            WithArguments("--copy-rules");
            if (!string.IsNullOrEmpty(copyRules))
            {
                 WithArguments(copyRules);
            }

            return this;
        }

        /// <summary>
        /// The maximum number of instances.
        /// </summary>
        public AzureMonitorAutoscaleProfileCreateTask MaxCount(string maxCount = null)
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
        public AzureMonitorAutoscaleProfileCreateTask MinCount(string minCount = null)
        {
            WithArguments("--min-count");
            if (!string.IsNullOrEmpty(minCount))
            {
                 WithArguments(minCount);
            }

            return this;
        }

        /// <summary>
        /// When the autoscale profile ends. Format depends on the type of profile.
        /// </summary>
        public AzureMonitorAutoscaleProfileCreateTask End(string end = null)
        {
            WithArguments("--end");
            if (!string.IsNullOrEmpty(end))
            {
                 WithArguments(end);
            }

            return this;
        }

        /// <summary>
        /// When the profile recurs. If omitted, a fixed (non-recurring) profile is created.
        /// </summary>
        public AzureMonitorAutoscaleProfileCreateTask Recurrence(string recurrence = null)
        {
            WithArguments("--recurrence");
            if (!string.IsNullOrEmpty(recurrence))
            {
                 WithArguments(recurrence);
            }

            return this;
        }

        /// <summary>
        /// When the autoscale profile begins. Format depends on the type of profile.
        /// </summary>
        public AzureMonitorAutoscaleProfileCreateTask Start(string start = null)
        {
            WithArguments("--start");
            if (!string.IsNullOrEmpty(start))
            {
                 WithArguments(start);
            }

            return this;
        }
     }
}
