
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Eventhubs
{
     public partial class AzureEventhubsGeorecoveryAliasSetTask : ExternalProcessTaskBase<AzureEventhubsGeorecoveryAliasSetTask>
     {
        
        /// <summary>
        /// Sets a Geo-Disaster Recovery Configuration Alias for the give Namespace.
        /// </summary>
        public AzureEventhubsGeorecoveryAliasSetTask(string alias = null ,  string namespaceName = null ,  string partnerNamespace = null ,  string resourceGroup = null)
        {
            WithArguments("az eventhubs georecovery-alias set");
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
        /// Alternate Name for the Alias, when the Namespace name and Alias name are same.
        /// </summary>
        public AzureEventhubsGeorecoveryAliasSetTask AlternateName(string alternateName = null)
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
