
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlServerDnsAliasTask : ExternalProcessTaskBase<AzureSqlServerDnsAliasTask>
     {
        
        /// <summary>
        /// Manage a server's DNS aliases.
        /// </summary>
        public AzureSqlServerDnsAliasTask()
        {
            WithArguments("az sql server dns-alias");
        }

        protected override string Description { get; set; }
        
     }
}
