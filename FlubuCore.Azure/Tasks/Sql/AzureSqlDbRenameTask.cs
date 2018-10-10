
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlDbRenameTask : ExternalProcessTaskBase<AzureSqlDbRenameTask>
     {
        
        /// <summary>
        /// Rename a database.
        /// </summary>
        public AzureSqlDbRenameTask(string name = null ,  string newName = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql db rename");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--new-name");
            if (!string.IsNullOrEmpty(newName))
            {
                 WithArguments(newName);
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
