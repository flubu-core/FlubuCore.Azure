
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlServerCreateTask : ExternalProcessTaskBase<AzureSqlServerCreateTask>
     {
        
        /// <summary>
        /// Create a server.
        /// </summary>
        public AzureSqlServerCreateTask(string adminPassword = null ,  string adminUser = null ,  string location = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az sql server create");
WithArguments("--admin-password");
            if (!string.IsNullOrEmpty(adminPassword))
            {
                 WithArguments(adminPassword);
            }

WithArguments("--admin-user");
            if (!string.IsNullOrEmpty(adminUser))
            {
                 WithArguments(adminUser);
            }

WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
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

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Generate and assign an Azure Active Directory Identity for this serverfor use with key management services like Azure KeyVault.
        /// </summary>
        public AzureSqlServerCreateTask AssignIdentity(string assignIdentity = null)
        {
            WithArguments("--assign-identity");
            if (!string.IsNullOrEmpty(assignIdentity))
            {
                 WithArguments(assignIdentity);
            }

            return this;
        }
     }
}
