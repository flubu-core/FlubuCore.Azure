
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlDbUpdateTask : ExternalProcessTaskBase<AzureSqlDbUpdateTask>
     {
        
        /// <summary>
        /// Update a database.
        /// </summary>
        public AzureSqlDbUpdateTask(string name = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql db update");
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
        /// The new maximum size of the database expressed in bytes.
        /// </summary>
        public AzureSqlDbUpdateTask MaxSize(string maxSize = null)
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
        public AzureSqlDbUpdateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Specifies whether to enable zone redundancy.
        /// </summary>
        public AzureSqlDbUpdateTask ZoneRedundant(string zoneRedundant = null)
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
        public AzureSqlDbUpdateTask Capacity(string capacity = null)
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
        public AzureSqlDbUpdateTask Edition(string edition = null)
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
        public AzureSqlDbUpdateTask Family(string family = null)
        {
            WithArguments("--family");
            if (!string.IsNullOrEmpty(family))
            {
                 WithArguments(family);
            }

            return this;
        }

        /// <summary>
        /// The name or resource id of the elastic pool to move the database into.
        /// </summary>
        public AzureSqlDbUpdateTask ElasticPool(string elasticPool = null)
        {
            WithArguments("--elastic-pool");
            if (!string.IsNullOrEmpty(elasticPool))
            {
                 WithArguments(elasticPool);
            }

            return this;
        }

        /// <summary>
        /// The name of the new service objective. If this is a standalone db service objective and the db is currently in an elastic pool, then the db is removed from the pool.
        /// </summary>
        public AzureSqlDbUpdateTask ServiceObjective(string serviceObjective = null)
        {
            WithArguments("--service-objective");
            if (!string.IsNullOrEmpty(serviceObjective))
            {
                 WithArguments(serviceObjective);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureSqlDbUpdateTask Add(string add = null)
        {
            WithArguments("--add");
            if (!string.IsNullOrEmpty(add))
            {
                 WithArguments(add);
            }

            return this;
        }

        /// <summary>
        /// When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.
        /// </summary>
        public AzureSqlDbUpdateTask ForceString(string forceString = null)
        {
            WithArguments("--force-string");
            if (!string.IsNullOrEmpty(forceString))
            {
                 WithArguments(forceString);
            }

            return this;
        }

        /// <summary>
        /// Remove a property or an element from a list.  Example: --remove property.list <indexToRemove> OR --remove propertyToRemove.
        /// </summary>
        public AzureSqlDbUpdateTask Remove(string remove = null)
        {
            WithArguments("--remove");
            if (!string.IsNullOrEmpty(remove))
            {
                 WithArguments(remove);
            }

            return this;
        }

        /// <summary>
        /// Update an object by specifying a property path and value to set.  Example: --set property1.property2=<value>.
        /// </summary>
        public AzureSqlDbUpdateTask Set(string set = null)
        {
            WithArguments("--set");
            if (!string.IsNullOrEmpty(set))
            {
                 WithArguments(set);
            }

            return this;
        }
     }
}
