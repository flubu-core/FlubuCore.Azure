
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Relay
{
     public partial class AzureRelayHycoCreateTask : ExternalProcessTaskBase<AzureRelayHycoCreateTask>
     {
        
        /// <summary>
        /// Create the Relay Service Hybrid Connection.
        /// </summary>
        public AzureRelayHycoCreateTask(string name = null ,  string namespaceName = null ,  string resourceGroup = null)
        {
            WithArguments("az relay hyco create");
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
        public AzureRelayHycoCreateTask RequiresClientAuthorization(string requiresClientAuthorization = null)
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
        public AzureRelayHycoCreateTask UserMetadata(string userMetadata = null)
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
