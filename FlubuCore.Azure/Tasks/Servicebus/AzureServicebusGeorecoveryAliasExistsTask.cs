
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Servicebus
{
     public partial class AzureServicebusGeorecoveryAliasExistsTask : ExternalProcessTaskBase<AzureServicebusGeorecoveryAliasExistsTask>
     {
        
        /// <summary>
        /// Check if Geo Recovery Alias Name is available.
        /// </summary>
        public AzureServicebusGeorecoveryAliasExistsTask(string alias = null ,  string namespaceName = null ,  string resourceGroup = null)
        {
            WithArguments("az servicebus georecovery-alias exists");
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
