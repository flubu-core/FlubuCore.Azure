
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Relay
{
     public partial class AzureRelayWcfrelayCreateTask : ExternalProcessTaskBase<AzureRelayWcfrelayCreateTask>
     {
        
        /// <summary>
        /// Create the Relay Service WCF Relay.
        /// </summary>
        public AzureRelayWcfrelayCreateTask(string name = null ,  string namespaceName = null ,  string relayType = null ,  string resourceGroup = null)
        {
            WithArguments("az relay wcfrelay create");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--namespace-name");
            if (!string.IsNullOrEmpty(namespaceName))
            {
                 WithArguments(namespaceName);
            }

WithArguments("--relay-type");
            if (!string.IsNullOrEmpty(relayType))
            {
                 WithArguments(relayType);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Indicates whether client authorization is required.
        /// </summary>
        public AzureRelayWcfrelayCreateTask RequiresClientAuthorization(string requiresClientAuthorization = null)
        {
            WithArguments("--requires-client-authorization");
            if (!string.IsNullOrEmpty(requiresClientAuthorization))
            {
                 WithArguments(requiresClientAuthorization);
            }

            return this;
        }

        /// <summary>
        /// Endpoint metadata.
        /// </summary>
        public AzureRelayWcfrelayCreateTask UserMetadata(string userMetadata = null)
        {
            WithArguments("--user-metadata");
            if (!string.IsNullOrEmpty(userMetadata))
            {
                 WithArguments(userMetadata);
            }

            return this;
        }
     }
}
