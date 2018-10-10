
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlDbTdeSetTask : ExternalProcessTaskBase<AzureSqlDbTdeSetTask>
     {
        
        /// <summary>
        /// Sets a database's transparent data encryption configuration.
        /// </summary>
        public AzureSqlDbTdeSetTask(string database = null ,  string resourceGroup = null ,  string server = null ,  string status = null)
        {
            WithArguments("az sql db tde set");
WithArguments("--database");
            if (!string.IsNullOrEmpty(database))
            {
                 WithArguments(database);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--server");
            if (!string.IsNullOrEmpty(server))
            {
                 WithArguments(server);
            }

WithArguments("--status");
            if (!string.IsNullOrEmpty(status))
            {
                 WithArguments(status);
            }

        }

        protected override string Description { get; set; }
        
     }
}
