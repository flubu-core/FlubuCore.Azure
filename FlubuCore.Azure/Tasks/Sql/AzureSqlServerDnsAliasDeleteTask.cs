
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlServerDnsAliasDeleteTask : ExternalProcessTaskBase<AzureSqlServerDnsAliasDeleteTask>
     {
        
        /// <summary>
        /// Deletes the server DNS alias with the given name.
        /// </summary>
        public AzureSqlServerDnsAliasDeleteTask(string name = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql server dns-alias delete");
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
