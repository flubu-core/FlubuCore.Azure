
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorLogAnalyticsQueryTask : ExternalProcessTaskBase<AzureMonitorLogAnalyticsQueryTask>
     {
        
        /// <summary>
        /// Query a Log Analytics workspace.
        /// </summary>
        public AzureMonitorLogAnalyticsQueryTask(string analyticsQuery = null ,  string workspace = null)
        {
            WithArguments("az monitor log-analytics query");
WithArguments("--analytics-query");
            if (!string.IsNullOrEmpty(analyticsQuery))
            {
                 WithArguments(analyticsQuery);
            }

WithArguments("--workspace");
            if (!string.IsNullOrEmpty(workspace))
            {
                 WithArguments(workspace);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Timespan over which to query. Defaults to querying all available data.
        /// </summary>
        public AzureMonitorLogAnalyticsQueryTask Timespan(string timespan = null)
        {
            WithArguments("--timespan");
            if (!string.IsNullOrEmpty(timespan))
            {
                 WithArguments(timespan);
            }

            return this;
        }

        /// <summary>
        /// Additional workspaces to union data for querying. Specify additional workspace IDs separated by space.
        /// </summary>
        public AzureMonitorLogAnalyticsQueryTask Workspaces(string workspaces = null)
        {
            WithArguments("--workspaces");
            if (!string.IsNullOrEmpty(workspaces))
            {
                 WithArguments(workspaces);
            }

            return this;
        }
     }
}
