
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlServerAdAdminCreateTask : ExternalProcessTaskBase<AzureSqlServerAdAdminCreateTask>
     {
        
        /// <summary>
        /// Create a new server Active Directory administrator.
        /// </summary>
        public AzureSqlServerAdAdminCreateTask(string displayName = null ,  string objectId = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql server ad-admin create");
WithArguments("--display-name");
            if (!string.IsNullOrEmpty(displayName))
            {
                 WithArguments(displayName);
            }

WithArguments("--object-id");
            if (!string.IsNullOrEmpty(objectId))
            {
                 WithArguments(objectId);
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
