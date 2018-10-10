
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mariadb
{
     public partial class AzureMariadbServerGeorestoreTask : ExternalProcessTaskBase<AzureMariadbServerGeorestoreTask>
     {
        
        /// <summary>
        /// Georestore a server from backup.
        /// </summary>
        public AzureMariadbServerGeorestoreTask(string location = null ,  string name = null ,  string resourceGroup = null ,  string sourceServer = null)
        {
            WithArguments("az mariadb server georestore");
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

WithArguments("--source-server");
            if (!string.IsNullOrEmpty(sourceServer))
            {
                 WithArguments(sourceServer);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The max days of retention, unit is days.
        /// </summary>
        public AzureMariadbServerGeorestoreTask BackupRetention(string backupRetention = null)
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
        public AzureMariadbServerGeorestoreTask GeoRedundantBackup(string geoRedundantBackup = null)
        {
            WithArguments("--geo-redundant-backup");
            if (!string.IsNullOrEmpty(geoRedundantBackup))
            {
                 WithArguments(geoRedundantBackup);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureMariadbServerGeorestoreTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1, GP_Gen5_8.
        /// </summary>
        public AzureMariadbServerGeorestoreTask SkuName(string skuName = null)
        {
            WithArguments("--sku-name");
            if (!string.IsNullOrEmpty(skuName))
            {
                 WithArguments(skuName);
            }

            return this;
        }
     }
}
