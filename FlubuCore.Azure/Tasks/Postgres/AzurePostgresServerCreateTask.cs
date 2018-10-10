
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Postgres
{
     public partial class AzurePostgresServerCreateTask : ExternalProcessTaskBase<AzurePostgresServerCreateTask>
     {
        
        /// <summary>
        /// Create a server.
        /// </summary>
        public AzurePostgresServerCreateTask(string name = null ,  string resourceGroup = null ,  string skuName = null ,  string adminUser = null)
        {
            WithArguments("az postgres server create");
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

WithArguments("--sku-name");
            if (!string.IsNullOrEmpty(skuName))
            {
                 WithArguments(skuName);
            }

WithArguments("--admin-user");
            if (!string.IsNullOrEmpty(adminUser))
            {
                 WithArguments(adminUser);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The number of days a backup is retained.
        /// </summary>
        public AzurePostgresServerCreateTask BackupRetention(string backupRetention = null)
        {
            WithArguments("--backup-retention");
            if (!string.IsNullOrEmpty(backupRetention))
            {
                 WithArguments(backupRetention);
            }

            return this;
        }

        /// <summary>
        /// Enable Geo-redundant or not for server backup.
        /// </summary>
        public AzurePostgresServerCreateTask GeoRedundantBackup(string geoRedundantBackup = null)
        {
            WithArguments("--geo-redundant-backup");
            if (!string.IsNullOrEmpty(geoRedundantBackup))
            {
                 WithArguments(geoRedundantBackup);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzurePostgresServerCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Enable ssl enforcement or not when connect to server.
        /// </summary>
        public AzurePostgresServerCreateTask SslEnforcement(string sslEnforcement = null)
        {
            WithArguments("--ssl-enforcement");
            if (!string.IsNullOrEmpty(sslEnforcement))
            {
                 WithArguments(sslEnforcement);
            }

            return this;
        }

        /// <summary>
        /// The max storage size of the server. Unit is megabytes.
        /// </summary>
        public AzurePostgresServerCreateTask StorageSize(string storageSize = null)
        {
            WithArguments("--storage-size");
            if (!string.IsNullOrEmpty(storageSize))
            {
                 WithArguments(storageSize);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzurePostgresServerCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Server version.
        /// </summary>
        public AzurePostgresServerCreateTask Version(string version = null)
        {
            WithArguments("--version");
            if (!string.IsNullOrEmpty(version))
            {
                 WithArguments(version);
            }

            return this;
        }

        /// <summary>
        /// The password of the administrator login.
        /// </summary>
        public AzurePostgresServerCreateTask AdminPassword(string adminPassword = null)
        {
            WithArguments("--admin-password");
            if (!string.IsNullOrEmpty(adminPassword))
            {
                 WithArguments(adminPassword);
            }

            return this;
        }
     }
}
