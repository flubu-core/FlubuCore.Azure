
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlDbCopyTask : ExternalProcessTaskBase<AzureSqlDbCopyTask>
     {
        
        /// <summary>
        /// Create a copy of a database.
        /// </summary>
        public AzureSqlDbCopyTask(string destName = null ,  string name = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql db copy");
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
        /// Name of the resouce group to create the copy in. If unspecified, defaults to the origin resource group.
        /// </summary>
        public AzureSqlDbCopyTask DestResourceGroup(string destResourceGroup = null)
        {
            WithArguments("--dest-resource-group");
            if (!string.IsNullOrEmpty(destResourceGroup))
            {
                 WithArguments(destResourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Name of the server to create the copy in. If unspecified, defaults to the origin server.
        /// </summary>
        public AzureSqlDbCopyTask DestServer(string destServer = null)
        {
            WithArguments("--dest-server");
            if (!string.IsNullOrEmpty(destServer))
            {
                 WithArguments(destServer);
            }

            return this;
        }

        /// <summary>
        /// The license type to apply for this database.
        /// </summary>
        public AzureSqlDbCopyTask LicenseType(string licenseType = null)
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
        public AzureSqlDbCopyTask NoWait(string noWait = null)
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
        public AzureSqlDbCopyTask Tags(string tags = null)
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
        public AzureSqlDbCopyTask ZoneRedundant(string zoneRedundant = null)
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
        public AzureSqlDbCopyTask Capacity(string capacity = null)
        {
            WithArguments("--capacity");
            if (!string.IsNullOrEmpty(capacity))
            {
                 WithArguments(capacity);
            }

            return this;
        }

        /// <summary>
        /// The compute generation component of the sku (for vcore skus only). Allowed values include: Gen4, Gen5.
        /// </summary>
        public AzureSqlDbCopyTask Family(string family = null)
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
        public AzureSqlDbCopyTask ElasticPool(string elasticPool = null)
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
        public AzureSqlDbCopyTask ServiceObjective(string serviceObjective = null)
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
