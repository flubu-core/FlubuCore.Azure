
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkCrossConnectionUpdateTask : ExternalProcessTaskBase<AzureNetworkCrossConnectionUpdateTask>
     {
        
        /// <summary>
        /// Update settings of an ExpressRoute circuit.
        /// </summary>
        public AzureNetworkCrossConnectionUpdateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az network cross-connection update");
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
        
        /// <summary>
        /// Bandwidth in Mbps of the circuit.
        /// </summary>
        public AzureNetworkCrossConnectionUpdateTask Bandwidth(string bandwidth = null)
        {
            WithArguments("--bandwidth");
            if (!string.IsNullOrEmpty(bandwidth))
            {
                 WithArguments(bandwidth);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureNetworkCrossConnectionUpdateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Service provider notes.
        /// </summary>
        public AzureNetworkCrossConnectionUpdateTask Notes(string notes = null)
        {
            WithArguments("--notes");
            if (!string.IsNullOrEmpty(notes))
            {
                 WithArguments(notes);
            }

            return this;
        }

        /// <summary>
        /// Provisioning state of the customer ExpressRoute circuit.
        /// </summary>
        public AzureNetworkCrossConnectionUpdateTask ProvisioningState(string provisioningState = null)
        {
            WithArguments("--provisioning-state");
            if (!string.IsNullOrEmpty(provisioningState))
            {
                 WithArguments(provisioningState);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureNetworkCrossConnectionUpdateTask Add(string add = null)
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
        public AzureNetworkCrossConnectionUpdateTask ForceString(string forceString = null)
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
        public AzureNetworkCrossConnectionUpdateTask Remove(string remove = null)
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
        public AzureNetworkCrossConnectionUpdateTask Set(string set = null)
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
