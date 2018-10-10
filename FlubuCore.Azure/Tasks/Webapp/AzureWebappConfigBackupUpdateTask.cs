
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Webapp
{
     public partial class AzureWebappConfigBackupUpdateTask : ExternalProcessTaskBase<AzureWebappConfigBackupUpdateTask>
     {
        
        /// <summary>
        /// Configure a new backup schedule for a web app.
        /// </summary>
        public AzureWebappConfigBackupUpdateTask(string resourceGroup = null ,  string webappName = null)
        {
            WithArguments("az webapp config backup update");
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
        public AzureWebappConfigBackupUpdateTask BackupName(string backupName = null)
        {
            WithArguments("--backup-name");
            if (!string.IsNullOrEmpty(backupName))
            {
                 WithArguments(backupName);
            }

            return this;
        }

        /// <summary>
        /// URL with SAS token to the blob storage container.
        /// </summary>
        public AzureWebappConfigBackupUpdateTask ContainerUrl(string containerUrl = null)
        {
            WithArguments("--container-url");
            if (!string.IsNullOrEmpty(containerUrl))
            {
                 WithArguments(containerUrl);
            }

            return this;
        }

        /// <summary>
        /// How often to backup. Use a number followed by d or h, e.g. 5d = 5 days, 2h = 2 hours.
        /// </summary>
        public AzureWebappConfigBackupUpdateTask Frequency(string frequency = null)
        {
            WithArguments("--frequency");
            if (!string.IsNullOrEmpty(frequency))
            {
                 WithArguments(frequency);
            }

            return this;
        }

        /// <summary>
        /// Always keep one backup, regardless of how old it is.
        /// </summary>
        public AzureWebappConfigBackupUpdateTask RetainOne(string retainOne = null)
        {
            WithArguments("--retain-one");
            if (!string.IsNullOrEmpty(retainOne))
            {
                 WithArguments(retainOne);
            }

            return this;
        }

        /// <summary>
        /// How many days to keep a backup before automatically deleting it. Set to 0 for indefinite retention.
        /// </summary>
        public AzureWebappConfigBackupUpdateTask Retention(string retention = null)
        {
            WithArguments("--retention");
            if (!string.IsNullOrEmpty(retention))
            {
                 WithArguments(retention);
            }

            return this;
        }

        /// <summary>
        /// The name of the slot. Default to the productions slot if not specified.
        /// </summary>
        public AzureWebappConfigBackupUpdateTask Slot(string slot = null)
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
        public AzureWebappConfigBackupUpdateTask DbConnectionString(string dbConnectionString = null)
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
        public AzureWebappConfigBackupUpdateTask DbName(string dbName = null)
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
        public AzureWebappConfigBackupUpdateTask DbType(string dbType = null)
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
