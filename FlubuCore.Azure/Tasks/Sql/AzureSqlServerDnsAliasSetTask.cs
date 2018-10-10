
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sql
{
     public partial class AzureSqlServerDnsAliasSetTask : ExternalProcessTaskBase<AzureSqlServerDnsAliasSetTask>
     {
        
        /// <summary>
        /// Sets a server to which DNS alias should point.
        /// </summary>
        public AzureSqlServerDnsAliasSetTask(string name = null ,  string originalServer = null ,  string resourceGroup = null ,  string server = null)
        {
            WithArguments("az sql server dns-alias set");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--original-server");
            if (!string.IsNullOrEmpty(originalServer))
            {
                 WithArguments(originalServer);
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
        
        public AzureSqlServerDnsAliasSetTask OriginalResourceGroup(string originalResourceGroup = null)
        {
            WithArguments("--original-resource-group");
            if (!string.IsNullOrEmpty(originalResourceGroup))
            {
                 WithArguments(originalResourceGroup);
            }

            return this;
        }

        public AzureSqlServerDnsAliasSetTask OriginalSubscriptionId(string originalSubscriptionId = null)
        {
            WithArguments("--original-subscription-id");
            if (!string.IsNullOrEmpty(originalSubscriptionId))
            {
                 WithArguments(originalSubscriptionId);
            }

            return this;
        }
     }
}
