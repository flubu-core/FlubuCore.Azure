
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlElasticPoolOpCancelTask : ExternalProcessTaskBase<AzureSqlElasticPoolOpCancelTask>
     {
        
        /// <summary>
        /// Cancels the asynchronous operation on the elastic pool.
        /// </summary>
        public AzureSqlElasticPoolOpCancelTask(string elasticPool = null ,  string name = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql elastic-pool op cancel");
WithArguments("--elastic-pool");
            if (!string.IsNullOrEmpty(elasticPool))
            {
                 WithArguments(elasticPool);
            }

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
