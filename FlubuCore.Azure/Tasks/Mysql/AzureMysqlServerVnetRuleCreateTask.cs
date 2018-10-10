
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Mysql
{
     public partial class AzureMysqlServerVnetRuleCreateTask : ExternalProcessTaskBase<AzureMysqlServerVnetRuleCreateTask>
     {
        
        /// <summary>
        /// Create a virtual network rule to allows access to a MySQL server.
        /// </summary>
        public AzureMysqlServerVnetRuleCreateTask(string name = null ,  string resourceGroup = null ,  string serverName = null ,  string subnet = null)
        {
            WithArguments("az mysql server vnet-rule create");
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

WithArguments("--server-name");
            if (!string.IsNullOrEmpty(serverName))
            {
                 WithArguments(serverName);
            }

WithArguments("--subnet");
            if (!string.IsNullOrEmpty(subnet))
            {
                 WithArguments(subnet);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Create vnet rule before virtual network has vnet service endpoint enabled.
        /// </summary>
        public AzureMysqlServerVnetRuleCreateTask IgnoreMissingEndpoint(string ignoreMissingEndpoint = null)
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
        public AzureMysqlServerVnetRuleCreateTask VnetName(string vnetName = null)
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
