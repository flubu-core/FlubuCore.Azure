
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlDwUpdateTask : ExternalProcessTaskBase<AzureSqlDwUpdateTask>
     {
        
        /// <summary>
        /// Update a data warehouse.
        /// </summary>
        public AzureSqlDwUpdateTask(string name = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql dw update");
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
        /// The max storage size. If no unit is specified, defaults to bytes (B).
        /// </summary>
        public AzureSqlDwUpdateTask MaxSize(string maxSize = null)
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
        public AzureSqlDwUpdateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// The service objective of the data warehouse. For example: DW100, DW1000c.
        /// </summary>
        public AzureSqlDwUpdateTask ServiceObjective(string serviceObjective = null)
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
        public AzureSqlDwUpdateTask Add(string add = null)
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
        public AzureSqlDwUpdateTask ForceString(string forceString = null)
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
        public AzureSqlDwUpdateTask Remove(string remove = null)
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
        public AzureSqlDwUpdateTask Set(string set = null)
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
