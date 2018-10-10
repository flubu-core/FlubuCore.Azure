
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlElasticPoolOpTask : ExternalProcessTaskBase<AzureSqlElasticPoolOpTask>
     {
        
        /// <summary>
        /// Manage operations on an elastic pool.
        /// </summary>
        public AzureSqlElasticPoolOpTask()
        {
            WithArguments("az sql elastic-pool op");
        }

        protected override string Description { get; set; }
        
     }
}
