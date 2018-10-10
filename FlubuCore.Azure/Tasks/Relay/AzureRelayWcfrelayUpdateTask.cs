
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Relay
{
     public partial class AzureRelayWcfrelayUpdateTask : ExternalProcessTaskBase<AzureRelayWcfrelayUpdateTask>
     {
        
        /// <summary>
        /// Updates existing Relay Service WCF Relay.
        /// </summary>
        public AzureRelayWcfrelayUpdateTask(string name = null ,  string namespaceName = null ,  string resourceGroup = null)
        {
            WithArguments("az relay wcfrelay update");
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
        /// Relay type.
        /// </summary>
        public AzureRelayWcfrelayUpdateTask RelayType(string relayType = null)
        {
            WithArguments("--relay-type");
            if (!string.IsNullOrEmpty(relayType))
            {
                 WithArguments(relayType);
            }

            return this;
        }

        /// <summary>
        /// Indicates whether client authorization is required.
        /// </summary>
        public AzureRelayWcfrelayUpdateTask RequiresClientAuthorization(string requiresClientAuthorization = null)
        {
            WithArguments("--requires-client-authorization");
            if (!string.IsNullOrEmpty(requiresClientAuthorization))
            {
                 WithArguments(requiresClientAuthorization);
            }

            return this;
        }

        /// <summary>
        /// Enumerates the possible values for the status of a messaging entity.
        /// </summary>
        public AzureRelayWcfrelayUpdateTask Status(string status = null)
        {
            WithArguments("--status");
            if (!string.IsNullOrEmpty(status))
            {
                 WithArguments(status);
            }

            return this;
        }

        /// <summary>
        /// Endpoint metadata.
        /// </summary>
        public AzureRelayWcfrelayUpdateTask UserMetadata(string userMetadata = null)
        {
            WithArguments("--user-metadata");
            if (!string.IsNullOrEmpty(userMetadata))
            {
                 WithArguments(userMetadata);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureRelayWcfrelayUpdateTask Add(string add = null)
        {
            WithArguments("--add");
            if (!string.IsNullOrEmpty(add))
            {
                 WithArguments(add);
            }

            return this;
        }

        /// <summary>
        /// When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.
        /// </summary>
        public AzureRelayWcfrelayUpdateTask ForceString(string forceString = null)
        {
            WithArguments("--force-string");
            if (!string.IsNullOrEmpty(forceString))
            {
                 WithArguments(forceString);
            }

            return this;
        }

        /// <summary>
        /// Remove a property or an element from a list.  Example: --remove property.list <indexToRemove> OR --remove propertyToRemove.
        /// </summary>
        public AzureRelayWcfrelayUpdateTask Remove(string remove = null)
        {
            WithArguments("--remove");
            if (!string.IsNullOrEmpty(remove))
            {
                 WithArguments(remove);
            }

            return this;
        }

        /// <summary>
        /// Update an object by specifying a property path and value to set.  Example: --set property1.property2=<value>.
        /// </summary>
        public AzureRelayWcfrelayUpdateTask Set(string set = null)
        {
            WithArguments("--set");
            if (!string.IsNullOrEmpty(set))
            {
                 WithArguments(set);
            }

            return this;
        }
     }
}
