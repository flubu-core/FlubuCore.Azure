
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlDwCreateTask : ExternalProcessTaskBase<AzureSqlDwCreateTask>
     {
        
        /// <summary>
        /// Create a data warehouse.
        /// </summary>
        public AzureSqlDwCreateTask(string name = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql dw create");
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
        /// The collation of the data warehouse.
        /// </summary>
        public AzureSqlDwCreateTask Collation(string collation = null)
        {
            WithArguments("--collation");
            if (!string.IsNullOrEmpty(collation))
            {
                 WithArguments(collation);
            }

            return this;
        }

        /// <summary>
        /// The max storage size. If no unit is specified, defaults to bytes (B).
        /// </summary>
        public AzureSqlDwCreateTask MaxSize(string maxSize = null)
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
        public AzureSqlDwCreateTask NoWait(string noWait = null)
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
        public AzureSqlDwCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Whether or not this database is zone redundant, which means the replicas of this database will be spread across multiple availability zones.
        /// </summary>
        public AzureSqlDwCreateTask ZoneRedundant(string zoneRedundant = null)
        {
            WithArguments("--zone-redundant");
            if (!string.IsNullOrEmpty(zoneRedundant))
            {
                 WithArguments(zoneRedundant);
            }

            return this;
        }

        /// <summary>
        /// The service objective for the new database. For example: DW100, DW1000c.
        /// </summary>
        public AzureSqlDwCreateTask ServiceObjective(string serviceObjective = null)
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
