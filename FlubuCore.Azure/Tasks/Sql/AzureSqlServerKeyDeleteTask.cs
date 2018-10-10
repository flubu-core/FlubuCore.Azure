
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlServerKeyDeleteTask : ExternalProcessTaskBase<AzureSqlServerKeyDeleteTask>
     {
        
        /// <summary>
        /// Deletes a server key.
        /// </summary>
        public AzureSqlServerKeyDeleteTask(string kid = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql server key delete");
WithArguments("--kid");
            if (!string.IsNullOrEmpty(kid))
            {
                 WithArguments(kid);
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
