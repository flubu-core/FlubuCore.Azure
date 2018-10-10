
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlDbCreateTask : ExternalProcessTaskBase<AzureSqlDbCreateTask>
     {
        
        /// <summary>
        /// Create a database.
        /// </summary>
        public AzureSqlDbCreateTask(string name = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql db create");
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
        public AzureSqlDbCreateTask LicenseType(string licenseType = null)
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
        public AzureSqlDbCreateTask MaxSize(string maxSize = null)
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
        public AzureSqlDbCreateTask NoWait(string noWait = null)
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
        public AzureSqlDbCreateTask Tags(string tags = null)
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
        public AzureSqlDbCreateTask ZoneRedundant(string zoneRedundant = null)
        {
            WithArguments("--zone-redundant");
            if (!string.IsNullOrEmpty(zoneRedundant))
            {
                 WithArguments(zoneRedundant);
            }

            return this;
        }

        /// <summary>
        /// Collation of the metadata catalog.
        /// </summary>
        public AzureSqlDbCreateTask CatalogCollation(string catalogCollation = null)
        {
            WithArguments("--catalog-collation");
            if (!string.IsNullOrEmpty(catalogCollation))
            {
                 WithArguments(catalogCollation);
            }

            return this;
        }

        /// <summary>
        /// The collation of the database.
        /// </summary>
        public AzureSqlDbCreateTask Collation(string collation = null)
        {
            WithArguments("--collation");
            if (!string.IsNullOrEmpty(collation))
            {
                 WithArguments(collation);
            }

            return this;
        }

        /// <summary>
        /// The name of the sample schema to apply when creating this database.
        /// </summary>
        public AzureSqlDbCreateTask SampleName(string sampleName = null)
        {
            WithArguments("--sample-name");
            if (!string.IsNullOrEmpty(sampleName))
            {
                 WithArguments(sampleName);
            }

            return this;
        }

        /// <summary>
        /// The capacity component of the sku in integer number of DTUs or vcores.
        /// </summary>
        public AzureSqlDbCreateTask Capacity(string capacity = null)
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
        public AzureSqlDbCreateTask Edition(string edition = null)
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
        public AzureSqlDbCreateTask Family(string family = null)
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
        public AzureSqlDbCreateTask ElasticPool(string elasticPool = null)
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
        public AzureSqlDbCreateTask ServiceObjective(string serviceObjective = null)
        {
            WithArguments("--service-objective");
            if (!string.IsNullOrEmpty(serviceObjective))
            {
                 WithArguments(serviceObjective);
            }

            return this;
        }
     }
}
