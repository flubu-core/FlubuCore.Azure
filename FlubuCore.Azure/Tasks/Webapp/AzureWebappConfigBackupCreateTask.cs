
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigBackupCreateTask : ExternalProcessTaskBase<AzureWebappConfigBackupCreateTask>
     {
        
        /// <summary>
        /// Create a backup of a web app.
        /// </summary>
        public AzureWebappConfigBackupCreateTask(string containerUrl = null ,  string resourceGroup = null ,  string webappName = null)
        {
            WithArguments("az webapp config backup create");
WithArguments("--container-url");
            if (!string.IsNullOrEmpty(containerUrl))
            {
                 WithArguments(containerUrl);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--webapp-name");
            if (!string.IsNullOrEmpty(webappName))
            {
                 WithArguments(webappName);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of the backup. If unspecified, the backup will be named with the webapp name and a timestamp.
        /// </summary>
        public AzureWebappConfigBackupCreateTask BackupName(string backupName = null)
        {
            WithArguments("--backup-name");
            if (!string.IsNullOrEmpty(backupName))
            {
                 WithArguments(backupName);
            }

            return this;
        }

        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappConfigBackupCreateTask Slot(string slot = null)
        {
            WithArguments("--slot");
            if (!string.IsNullOrEmpty(slot))
            {
                 WithArguments(slot);
            }

            return this;
        }

        /// <summary>
        /// Connection string for the database in the backup.
        /// </summary>
        public AzureWebappConfigBackupCreateTask DbConnectionString(string dbConnectionString = null)
        {
            WithArguments("--db-connection-string");
            if (!string.IsNullOrEmpty(dbConnectionString))
            {
                 WithArguments(dbConnectionString);
            }

            return this;
        }

        /// <summary>
        /// Name of the database in the backup.
        /// </summary>
        public AzureWebappConfigBackupCreateTask DbName(string dbName = null)
        {
            WithArguments("--db-name");
            if (!string.IsNullOrEmpty(dbName))
            {
                 WithArguments(dbName);
            }

            return this;
        }

        /// <summary>
        /// Type of database in the backup.
        /// </summary>
        public AzureWebappConfigBackupCreateTask DbType(string dbType = null)
        {
            WithArguments("--db-type");
            if (!string.IsNullOrEmpty(dbType))
            {
                 WithArguments(dbType);
            }

            return this;
        }
     }
}
