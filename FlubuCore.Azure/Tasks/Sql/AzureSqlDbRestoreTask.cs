
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlDbRestoreTask : ExternalProcessTaskBase<AzureSqlDbRestoreTask>
     {
        
        /// <summary>
        /// Create a new database by restoring from a backup.
        /// </summary>
        public AzureSqlDbRestoreTask(string destName = null ,  string name = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql db restore");
WithArguments("--dest-name");
            if (!string.IsNullOrEmpty(destName))
            {
                 WithArguments(destName);
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

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The license type to apply for this database.
        /// </summary>
        public AzureSqlDbRestoreTask LicenseType(string licenseType = null)
        {
            WithArguments("--license-type");
            if (!string.IsNullOrEmpty(licenseType))
            {
                 WithArguments(licenseType);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureSqlDbRestoreTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureSqlDbRestoreTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Specifies whether to enable zone redundancy.
        /// </summary>
        public AzureSqlDbRestoreTask ZoneRedundant(string zoneRedundant = null)
        {
            WithArguments("--zone-redundant");
            if (!string.IsNullOrEmpty(zoneRedundant))
            {
                 WithArguments(zoneRedundant);
            }

            return this;
        }

        /// <summary>
        /// The capacity component of the sku in integer number of DTUs or vcores.
        /// </summary>
        public AzureSqlDbRestoreTask Capacity(string capacity = null)
        {
            WithArguments("--capacity");
            if (!string.IsNullOrEmpty(capacity))
            {
                 WithArguments(capacity);
            }

            return this;
        }

        /// <summary>
        /// The edition component of the sku. Allowed values include: Basic, Standard, Premium, GeneralPurpose, BusinessCritical.
        /// </summary>
        public AzureSqlDbRestoreTask Edition(string edition = null)
        {
            WithArguments("--edition");
            if (!string.IsNullOrEmpty(edition))
            {
                 WithArguments(edition);
            }

            return this;
        }

        /// <summary>
        /// The compute generation component of the sku (for vcore skus only). Allowed values include: Gen4, Gen5.
        /// </summary>
        public AzureSqlDbRestoreTask Family(string family = null)
        {
            WithArguments("--family");
            if (!string.IsNullOrEmpty(family))
            {
                 WithArguments(family);
            }

            return this;
        }

        /// <summary>
        /// The name or resource id of the elastic pool to create the database in.
        /// </summary>
        public AzureSqlDbRestoreTask ElasticPool(string elasticPool = null)
        {
            WithArguments("--elastic-pool");
            if (!string.IsNullOrEmpty(elasticPool))
            {
                 WithArguments(elasticPool);
            }

            return this;
        }

        /// <summary>
        /// The service objective for the new database. For example: Basic, S0, P1, GP_Gen4_1, BC_Gen5_2.
        /// </summary>
        public AzureSqlDbRestoreTask ServiceObjective(string serviceObjective = null)
        {
            WithArguments("--service-objective");
            if (!string.IsNullOrEmpty(serviceObjective))
            {
                 WithArguments(serviceObjective);
            }

            return this;
        }

        /// <summary>
        /// If specified, restore from a deleted database instead of from an existing database. Must match the deleted time of a deleted database in the same server. Either --time or --deleted-time (or both) must be specified.
        /// </summary>
        public AzureSqlDbRestoreTask DeletedTime(string deletedTime = null)
        {
            WithArguments("--deleted-time");
            if (!string.IsNullOrEmpty(deletedTime))
            {
                 WithArguments(deletedTime);
            }

            return this;
        }

        /// <summary>
        /// The point in time of the source database that will be restored to create the new database. Must be greater than or equal to the source database's earliestRestoreDate value. Either --time or --deleted-time (or both) must be specified.
        /// </summary>
        public AzureSqlDbRestoreTask Time(string time = null)
        {
            WithArguments("--time");
            if (!string.IsNullOrEmpty(time))
            {
                 WithArguments(time);
            }

            return this;
        }
     }
}
