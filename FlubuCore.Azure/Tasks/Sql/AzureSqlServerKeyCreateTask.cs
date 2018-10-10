
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlServerKeyCreateTask : ExternalProcessTaskBase<AzureSqlServerKeyCreateTask>
     {
        
        /// <summary>
        /// Creates a server key.
        /// </summary>
        public AzureSqlServerKeyCreateTask(string kid = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql server key create");
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
