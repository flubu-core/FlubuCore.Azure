
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlDbTdeTask : ExternalProcessTaskBase<AzureSqlDbTdeTask>
     {
        
        /// <summary>
        /// Manage a database's transparent data encryption.
        /// </summary>
        public AzureSqlDbTdeTask()
        {
            WithArguments("az sql db tde");
        }

        protected override string Description { get; set; }
        
     }
}
