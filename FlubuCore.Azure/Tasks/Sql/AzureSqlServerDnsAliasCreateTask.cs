
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlServerDnsAliasCreateTask : ExternalProcessTaskBase<AzureSqlServerDnsAliasCreateTask>
     {
        
        /// <summary>
        /// Creates a server dns alias.
        /// </summary>
        public AzureSqlServerDnsAliasCreateTask(string name = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql server dns-alias create");
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
