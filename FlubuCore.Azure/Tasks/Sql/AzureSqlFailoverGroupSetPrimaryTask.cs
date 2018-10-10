
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlFailoverGroupSetPrimaryTask : ExternalProcessTaskBase<AzureSqlFailoverGroupSetPrimaryTask>
     {
        
        /// <summary>
        /// Set the primary of the failover group by failing over all databases from the current primary server.
        /// </summary>
        public AzureSqlFailoverGroupSetPrimaryTask(string name = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql failover-group set-primary");
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
        
        public AzureSqlFailoverGroupSetPrimaryTask AllowDataLoss(string allowDataLoss = null)
        {
            WithArguments("--allow-data-loss");
            if (!string.IsNullOrEmpty(allowDataLoss))
            {
                 WithArguments(allowDataLoss);
            }

            return this;
        }
     }
}
