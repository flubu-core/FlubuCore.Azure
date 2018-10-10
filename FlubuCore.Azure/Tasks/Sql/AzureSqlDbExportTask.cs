
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlDbExportTask : ExternalProcessTaskBase<AzureSqlDbExportTask>
     {
        
        /// <summary>
        /// Export a database to a bacpac.
        /// </summary>
        public AzureSqlDbExportTask(string adminPassword = null ,  string adminUser = null ,  string name = null ,  string resourceGroup = null ,  string server = null ,  string storageKey = null ,  string storageKeyType = null ,  string storageUri = null)
        {
            WithArguments("az sql db export");
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

WithArguments("--storage-key");
            if (!string.IsNullOrEmpty(storageKey))
            {
                 WithArguments(storageKey);
            }

WithArguments("--storage-key-type");
            if (!string.IsNullOrEmpty(storageKeyType))
            {
                 WithArguments(storageKeyType);
            }

WithArguments("--storage-uri");
            if (!string.IsNullOrEmpty(storageUri))
            {
                 WithArguments(storageUri);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The authentication type.
        /// </summary>
        public AzureSqlDbExportTask AuthType(string authType = null)
        {
            WithArguments("--auth-type");
            if (!string.IsNullOrEmpty(authType))
            {
                 WithArguments(authType);
            }

            return this;
        }
     }
}
