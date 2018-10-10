
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlDbReplicaTask : ExternalProcessTaskBase<AzureSqlDbReplicaTask>
     {
        
        /// <summary>
        /// Manage replication between databases.
        /// </summary>
        public AzureSqlDbReplicaTask()
        {
            WithArguments("az sql db replica");
        }

        protected override string Description { get; set; }
        
     }
}
