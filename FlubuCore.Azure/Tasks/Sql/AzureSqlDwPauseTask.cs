
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlDwPauseTask : ExternalProcessTaskBase<AzureSqlDwPauseTask>
     {
        
        /// <summary>
        /// Pauses a datawarehouse.
        /// </summary>
        public AzureSqlDwPauseTask(string name = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql dw pause");
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
