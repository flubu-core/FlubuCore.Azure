
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusGeorecoveryAliasFailOverTask : ExternalProcessTaskBase<AzureServicebusGeorecoveryAliasFailOverTask>
     {
        
        /// <summary>
        /// Invokes Service Bus Geo-Disaster Recovery Configuration Alias failover and re-configure the alias to point to the secondary namespace.
        /// </summary>
        public AzureServicebusGeorecoveryAliasFailOverTask(string alias = null ,  string namespaceName = null ,  string resourceGroup = null)
        {
            WithArguments("az servicebus georecovery-alias fail-over");
WithArguments("--alias");
            if (!string.IsNullOrEmpty(alias))
            {
                 WithArguments(alias);
            }

WithArguments("--namespace-name");
            if (!string.IsNullOrEmpty(namespaceName))
            {
                 WithArguments(namespaceName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
     }
}
