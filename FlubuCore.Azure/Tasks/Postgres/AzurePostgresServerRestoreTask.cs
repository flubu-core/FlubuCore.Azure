
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Postgres
{
     public partial class AzurePostgresServerRestoreTask : ExternalProcessTaskBase<AzurePostgresServerRestoreTask>
     {
        
        /// <summary>
        /// Restore a server from backup.
        /// </summary>
        public AzurePostgresServerRestoreTask(string name = null ,  string resourceGroup = null ,  string restorePointInTime = null ,  string sourceServer = null)
        {
            WithArguments("az postgres server restore");
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

WithArguments("--restore-point-in-time");
            if (!string.IsNullOrEmpty(restorePointInTime))
            {
                 WithArguments(restorePointInTime);
            }

WithArguments("--source-server");
            if (!string.IsNullOrEmpty(sourceServer))
            {
                 WithArguments(sourceServer);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzurePostgresServerRestoreTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }
     }
}
