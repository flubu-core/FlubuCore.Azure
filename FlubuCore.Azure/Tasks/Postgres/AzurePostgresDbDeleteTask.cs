
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Postgres
{
     public partial class AzurePostgresDbDeleteTask : ExternalProcessTaskBase<AzurePostgresDbDeleteTask>
     {
        
        /// <summary>
        /// Delete a database.
        /// </summary>
        public AzurePostgresDbDeleteTask(string name = null ,  string resourceGroup = null ,  string serverName = null)
        {
            WithArguments("az postgres db delete");
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
        
        /// <summary>
        /// Do not prompt for confirmation.
        /// </summary>
        public AzurePostgresDbDeleteTask Yes(string yes = null)
        {
            WithArguments("--yes");
            if (!string.IsNullOrEmpty(yes))
            {
                 WithArguments(yes);
            }

            return this;
        }
     }
}
