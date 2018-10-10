
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlElasticPoolTask : ExternalProcessTaskBase<AzureSqlElasticPoolTask>
     {
        
        /// <summary>
        /// Manage elastic pools.
        /// </summary>
        public AzureSqlElasticPoolTask()
        {
            WithArguments("az sql elastic-pool");
        }

        protected override string Description { get; set; }
        
     }
}
