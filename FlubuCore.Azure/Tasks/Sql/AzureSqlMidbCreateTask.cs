
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlMidbCreateTask : ExternalProcessTaskBase<AzureSqlMidbCreateTask>
     {
        
        /// <summary>
        /// Create a managed database.
        /// </summary>
        public AzureSqlMidbCreateTask(string managedInstance = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az sql midb create");
WithArguments("--managed-instance");
            if (!string.IsNullOrEmpty(managedInstance))
            {
                 WithArguments(managedInstance);
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

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The collation of the Azure SQL Managed Database collation to use, e.g.: SQL_Latin1_General_CP1_CI_AS or Latin1_General_100_CS_AS_SC.
        /// </summary>
        public AzureSqlMidbCreateTask Collation(string collation = null)
        {
            WithArguments("--collation");
            if (!string.IsNullOrEmpty(collation))
            {
                 WithArguments(collation);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureSqlMidbCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }
     }
}
