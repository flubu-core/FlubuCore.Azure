
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusGeorecoveryAliasSetTask : ExternalProcessTaskBase<AzureServicebusGeorecoveryAliasSetTask>
     {
        
        /// <summary>
        /// Sets Service Bus Geo-Disaster Recovery Configuration Alias for the give Namespace.
        /// </summary>
        public AzureServicebusGeorecoveryAliasSetTask(string alias = null ,  string namespaceName = null ,  string partnerNamespace = null ,  string resourceGroup = null)
        {
            WithArguments("az servicebus georecovery-alias set");
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

WithArguments("--partner-namespace");
            if (!string.IsNullOrEmpty(partnerNamespace))
            {
                 WithArguments(partnerNamespace);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Alternate Name (Post failover) for Primary Namespace, when Namespace name and Alias name are same.
        /// </summary>
        public AzureServicebusGeorecoveryAliasSetTask AlternateName(string alternateName = null)
        {
            WithArguments("--alternate-name");
            if (!string.IsNullOrEmpty(alternateName))
            {
                 WithArguments(alternateName);
            }

            return this;
        }
     }
}
