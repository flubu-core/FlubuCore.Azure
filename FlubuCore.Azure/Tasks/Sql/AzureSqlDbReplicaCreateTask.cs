
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlDbReplicaCreateTask : ExternalProcessTaskBase<AzureSqlDbReplicaCreateTask>
     {
        
        /// <summary>
        /// Create a database as a readable secondary replica of an existing database.
        /// </summary>
        public AzureSqlDbReplicaCreateTask(string name = null ,  string partnerServer = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql db replica create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--partner-server");
            if (!string.IsNullOrEmpty(partnerServer))
            {
                 WithArguments(partnerServer);
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
        public AzureSqlDbReplicaCreateTask LicenseType(string licenseType = null)
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
        public AzureSqlDbReplicaCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Name of the resource group to create the new replica in. If unspecified, defaults to the origin resource group.
        /// </summary>
        public AzureSqlDbReplicaCreateTask PartnerResourceGroup(string partnerResourceGroup = null)
        {
            WithArguments("--partner-resource-group");
            if (!string.IsNullOrEmpty(partnerResourceGroup))
            {
                 WithArguments(partnerResourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureSqlDbReplicaCreateTask Tags(string tags = null)
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
        public AzureSqlDbReplicaCreateTask ZoneRedundant(string zoneRedundant = null)
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
        public AzureSqlDbReplicaCreateTask Capacity(string capacity = null)
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
        public AzureSqlDbReplicaCreateTask Family(string family = null)
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
        public AzureSqlDbReplicaCreateTask ElasticPool(string elasticPool = null)
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
        public AzureSqlDbReplicaCreateTask ServiceObjective(string serviceObjective = null)
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
