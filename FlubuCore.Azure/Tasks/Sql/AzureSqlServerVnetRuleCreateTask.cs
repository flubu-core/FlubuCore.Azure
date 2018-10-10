
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlServerVnetRuleCreateTask : ExternalProcessTaskBase<AzureSqlServerVnetRuleCreateTask>
     {
        
        /// <summary>
        /// Create a virtual network rule to allows access to an Azure SQL server.
        /// </summary>
        public AzureSqlServerVnetRuleCreateTask(string name = null ,  string resourceGroup = null ,  string server = null ,  string subnet = null)
        {
            WithArguments("az sql server vnet-rule create");
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

WithArguments("--subnet");
            if (!string.IsNullOrEmpty(subnet))
            {
                 WithArguments(subnet);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Create firewall rule before the virtual network has vnet service endpoint enabled.
        /// </summary>
        public AzureSqlServerVnetRuleCreateTask IgnoreMissingEndpoint(string ignoreMissingEndpoint = null)
        {
            WithArguments("--ignore-missing-endpoint");
            if (!string.IsNullOrEmpty(ignoreMissingEndpoint))
            {
                 WithArguments(ignoreMissingEndpoint);
            }

            return this;
        }

        /// <summary>
        /// The virtual network name.
        /// </summary>
        public AzureSqlServerVnetRuleCreateTask VnetName(string vnetName = null)
        {
            WithArguments("--vnet-name");
            if (!string.IsNullOrEmpty(vnetName))
            {
                 WithArguments(vnetName);
            }

            return this;
        }
     }
}
