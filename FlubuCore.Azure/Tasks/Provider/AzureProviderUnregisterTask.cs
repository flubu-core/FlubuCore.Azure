
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Provider
{
     public partial class AzureProviderUnregisterTask : ExternalProcessTaskBase<AzureProviderUnregisterTask>
     {
        
        /// <summary>
        /// Unregister a provider.
        /// </summary>
        public AzureProviderUnregisterTask(string @namespace = null)
        {
            WithArguments("az provider unregister");
WithArguments("--namespace");
            if (!string.IsNullOrEmpty(@namespace))
            {
                 WithArguments(@namespace);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Wait for unregistration to finish.
        /// </summary>
        public AzureProviderUnregisterTask Wait(string wait = null)
        {
            WithArguments("--wait");
            if (!string.IsNullOrEmpty(wait))
            {
                 WithArguments(wait);
            }

            return this;
        }
     }
}
