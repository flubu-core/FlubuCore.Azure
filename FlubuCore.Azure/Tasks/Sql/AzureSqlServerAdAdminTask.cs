
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlServerAdAdminTask : ExternalProcessTaskBase<AzureSqlServerAdAdminTask>
     {
        
        /// <summary>
        /// Manage a server's Active Directory administrator.
        /// </summary>
        public AzureSqlServerAdAdminTask()
        {
            WithArguments("az sql server ad-admin");
        }

        protected override string Description { get; set; }
        
     }
}
