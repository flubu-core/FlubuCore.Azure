
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Maps
{
     public partial class AzureMapsAccountKeysRenewTask : ExternalProcessTaskBase<AzureMapsAccountKeysRenewTask>
     {
        
        /// <summary>
        /// Renew either the primary or secondary key for use with the Maps APIs.
        /// </summary>
        public AzureMapsAccountKeysRenewTask(string key = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az maps account keys renew");
WithArguments("--key");
            if (!string.IsNullOrEmpty(key))
            {
                 WithArguments(key);
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
        
     }
}
