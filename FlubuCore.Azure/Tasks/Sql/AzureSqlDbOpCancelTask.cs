
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlDbOpCancelTask : ExternalProcessTaskBase<AzureSqlDbOpCancelTask>
     {
        
        /// <summary>
        /// Cancels the asynchronous operation on the database.
        /// </summary>
        public AzureSqlDbOpCancelTask(string database = null ,  string name = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql db op cancel");
WithArguments("--database");
            if (!string.IsNullOrEmpty(database))
            {
                 WithArguments(database);
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

WithArguments("--server");
            if (!string.IsNullOrEmpty(server))
            {
                 WithArguments(server);
            }

        }

        protected override string Description { get; set; }
        
     }
}
