
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlFailoverGroupDeleteTask : ExternalProcessTaskBase<AzureSqlFailoverGroupDeleteTask>
     {
        
        /// <summary>
        /// Deletes a failover group.
        /// </summary>
        public AzureSqlFailoverGroupDeleteTask(string name = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql failover-group delete");
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
