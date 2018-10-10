
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Signalr
{
     public partial class AzureSignalrKeyRenewTask : ExternalProcessTaskBase<AzureSignalrKeyRenewTask>
     {
        
        /// <summary>
        /// Regenerate the access key for a SignalR Service.
        /// </summary>
        public AzureSignalrKeyRenewTask(string keyType = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az signalr key renew");
WithArguments("--key-type");
            if (!string.IsNullOrEmpty(keyType))
            {
                 WithArguments(keyType);
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
