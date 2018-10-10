
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Provider
{
     public partial class AzureProviderRegisterTask : ExternalProcessTaskBase<AzureProviderRegisterTask>
     {
        
        /// <summary>
        /// Register a provider.
        /// </summary>
        public AzureProviderRegisterTask(string @namespace = null)
        {
            WithArguments("az provider register");
WithArguments("--namespace");
            if (!string.IsNullOrEmpty(@namespace))
            {
                 WithArguments(@namespace);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Wait for the registration to finish.
        /// </summary>
        public AzureProviderRegisterTask Wait(string wait = null)
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
