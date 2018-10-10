
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigBackupRestoreTask : ExternalProcessTaskBase<AzureWebappConfigBackupRestoreTask>
     {
        
        /// <summary>
        /// Restore a web app from a backup.
        /// </summary>
        public AzureWebappConfigBackupRestoreTask(string backupName = null ,  string containerUrl = null ,  string resourceGroup = null ,  string webappName = null)
        {
            WithArguments("az webapp config backup restore");
WithArguments("--backup-name");
            if (!string.IsNullOrEmpty(backupName))
            {
                 WithArguments(backupName);
            }

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
        /// Ignores custom hostnames stored in the backup.
        /// </summary>
        public AzureWebappConfigBackupRestoreTask IgnoreHostnameConflict(string ignoreHostnameConflict = null)
        {
            WithArguments("--ignore-hostname-conflict");
            if (!string.IsNullOrEmpty(ignoreHostnameConflict))
            {
                 WithArguments(ignoreHostnameConflict);
            }

            return this;
        }

        /// <summary>
        /// Overwrite the source webapp, if --target-name is not specified.
        /// </summary>
        public AzureWebappConfigBackupRestoreTask Overwrite(string overwrite = null)
        {
            WithArguments("--overwrite");
            if (!string.IsNullOrEmpty(overwrite))
            {
                 WithArguments(overwrite);
            }

            return this;
        }

        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappConfigBackupRestoreTask Slot(string slot = null)
        {
            WithArguments("--slot");
            if (!string.IsNullOrEmpty(slot))
            {
                 WithArguments(slot);
            }

            return this;
        }

        /// <summary>
        /// The name to use for the restored webapp. If unspecified, will default to the name that was used when the backup was created.
        /// </summary>
        public AzureWebappConfigBackupRestoreTask TargetName(string targetName = null)
        {
            WithArguments("--target-name");
            if (!string.IsNullOrEmpty(targetName))
            {
                 WithArguments(targetName);
            }

            return this;
        }

        /// <summary>
        /// Connection string for the database in the backup.
        /// </summary>
        public AzureWebappConfigBackupRestoreTask DbConnectionString(string dbConnectionString = null)
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
        public AzureWebappConfigBackupRestoreTask DbName(string dbName = null)
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
        public AzureWebappConfigBackupRestoreTask DbType(string dbType = null)
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
