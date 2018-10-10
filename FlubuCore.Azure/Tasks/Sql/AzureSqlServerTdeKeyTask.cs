
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlServerTdeKeyTask : ExternalProcessTaskBase<AzureSqlServerTdeKeyTask>
     {
        
        /// <summary>
        /// Manage a server's encryption protector.
        /// </summary>
        public AzureSqlServerTdeKeyTask()
        {
            WithArguments("az sql server tde-key");
        }

        protected override string Description { get; set; }
        
     }
}
