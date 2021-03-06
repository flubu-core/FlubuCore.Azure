
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mariadb
{
     public partial class AzureMariadbServerLogsDownloadTask : ExternalProcessTaskBase<AzureMariadbServerLogsDownloadTask>
     {
        
        /// <summary>
        /// Download log files.
        /// </summary>
        public AzureMariadbServerLogsDownloadTask(string name = null ,  string resourceGroup = null ,  string serverName = null)
        {
            WithArguments("az mariadb server-logs download");
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

WithArguments("--server-name");
            if (!string.IsNullOrEmpty(serverName))
            {
                 WithArguments(serverName);
            }

        }

        protected override string Description { get; set; }
        
     }
}
