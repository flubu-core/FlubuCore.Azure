
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Search
{
     public partial class AzureSearchAdminKeyRenewTask : ExternalProcessTaskBase<AzureSearchAdminKeyRenewTask>
     {
        
        /// <summary>
        /// Regenerates either the primary or secondary admin API key.
        /// </summary>
        public AzureSearchAdminKeyRenewTask(string keyKind = null ,  string resourceGroup = null ,  string serviceName = null)
        {
            WithArguments("az search admin-key renew");
WithArguments("--key-kind");
            if (!string.IsNullOrEmpty(keyKind))
            {
                 WithArguments(keyKind);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

WithArguments("--service-name");
            if (!string.IsNullOrEmpty(serviceName))
            {
                 WithArguments(serviceName);
            }

        }

        protected override string Description { get; set; }
        
     }
}
