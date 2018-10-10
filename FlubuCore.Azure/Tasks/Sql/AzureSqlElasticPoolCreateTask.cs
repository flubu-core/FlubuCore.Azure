
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlElasticPoolCreateTask : ExternalProcessTaskBase<AzureSqlElasticPoolCreateTask>
     {
        
        /// <summary>
        /// Create an elastic pool.
        /// </summary>
        public AzureSqlElasticPoolCreateTask(string name = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql elastic-pool create");
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
        /// The maximum capacity (in DTUs or vcores) any one database can consume.
        /// </summary>
        public AzureSqlElasticPoolCreateTask DbDtuMax(string dbDtuMax = null)
        {
            WithArguments("--db-dtu-max");
            if (!string.IsNullOrEmpty(dbDtuMax))
            {
                 WithArguments(dbDtuMax);
            }

            return this;
        }

        /// <summary>
        /// The minumum capacity (in DTUs or vcores) each database is guaranteed.
        /// </summary>
        public AzureSqlElasticPoolCreateTask DbDtuMin(string dbDtuMin = null)
        {
            WithArguments("--db-dtu-min");
            if (!string.IsNullOrEmpty(dbDtuMin))
            {
                 WithArguments(dbDtuMin);
            }

            return this;
        }

        /// <summary>
        /// The license type to apply for this elastic pool.
        /// </summary>
        public AzureSqlElasticPoolCreateTask LicenseType(string licenseType = null)
        {
            WithArguments("--license-type");
            if (!string.IsNullOrEmpty(licenseType))
            {
                 WithArguments(licenseType);
            }

            return this;
        }

        /// <summary>
        /// The max storage size. If no unit is specified, defaults to bytes (B).
        /// </summary>
        public AzureSqlElasticPoolCreateTask MaxSize(string maxSize = null)
        {
            WithArguments("--max-size");
            if (!string.IsNullOrEmpty(maxSize))
            {
                 WithArguments(maxSize);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureSqlElasticPoolCreateTask NoWait(string noWait = null)
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
        public AzureSqlElasticPoolCreateTask Tags(string tags = null)
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
        public AzureSqlElasticPoolCreateTask ZoneRedundant(string zoneRedundant = null)
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
        public AzureSqlElasticPoolCreateTask Capacity(string capacity = null)
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
        public AzureSqlElasticPoolCreateTask Edition(string edition = null)
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
        public AzureSqlElasticPoolCreateTask Family(string family = null)
        {
            WithArguments("--family");
            if (!string.IsNullOrEmpty(family))
            {
                 WithArguments(family);
            }

            return this;
        }
     }
}
