
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkServiceEndpointPolicyDefinitionUpdateTask : ExternalProcessTaskBase<AzureNetworkServiceEndpointPolicyDefinitionUpdateTask>
     {
        
        /// <summary>
        /// Update a service endpoint policy definition.
        /// </summary>
        public AzureNetworkServiceEndpointPolicyDefinitionUpdateTask(string name = null ,  string policyName = null ,  string resourceGroup = null)
        {
            WithArguments("az network service-endpoint policy-definition update");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--policy-name");
            if (!string.IsNullOrEmpty(policyName))
            {
                 WithArguments(policyName);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Service name the policy definition applies to.
        /// </summary>
        public AzureNetworkServiceEndpointPolicyDefinitionUpdateTask Service(string service = null)
        {
            WithArguments("--service");
            if (!string.IsNullOrEmpty(service))
            {
                 WithArguments(service);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of service resources the definition applies to.
        /// </summary>
        public AzureNetworkServiceEndpointPolicyDefinitionUpdateTask ServiceResources(string serviceResources = null)
        {
            WithArguments("--service-resources");
            if (!string.IsNullOrEmpty(serviceResources))
            {
                 WithArguments(serviceResources);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkServiceEndpointPolicyDefinitionUpdateTask Add(string add = null)
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
        public AzureNetworkServiceEndpointPolicyDefinitionUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkServiceEndpointPolicyDefinitionUpdateTask Remove(string remove = null)
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
        public AzureNetworkServiceEndpointPolicyDefinitionUpdateTask Set(string set = null)
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
