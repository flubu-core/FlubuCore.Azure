
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlServerAdAdminDeleteTask : ExternalProcessTaskBase<AzureSqlServerAdAdminDeleteTask>
     {
        
        /// <summary>
        /// Deletes an existing server Active Directory Administrator.
        /// </summary>
        public AzureSqlServerAdAdminDeleteTask(string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql server ad-admin delete");
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
