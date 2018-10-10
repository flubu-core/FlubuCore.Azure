
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Postgres
{
     public partial class AzurePostgresDbCreateTask : ExternalProcessTaskBase<AzurePostgresDbCreateTask>
     {
        
        /// <summary>
        /// Create a PostgreSQL database.
        /// </summary>
        public AzurePostgresDbCreateTask(string name = null ,  string resourceGroup = null ,  string serverName = null)
        {
            WithArguments("az postgres db create");
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
        /// The charset of the database.
        /// </summary>
        public AzurePostgresDbCreateTask Charset(string charset = null)
        {
            WithArguments("--charset");
            if (!string.IsNullOrEmpty(charset))
            {
                 WithArguments(charset);
            }

            return this;
        }

        /// <summary>
        /// The collation of the database.
        /// </summary>
        public AzurePostgresDbCreateTask Collation(string collation = null)
        {
            WithArguments("--collation");
            if (!string.IsNullOrEmpty(collation))
            {
                 WithArguments(collation);
            }

            return this;
        }
     }
}
