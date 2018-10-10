
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorDiagnosticSettingsUpdateTask : ExternalProcessTaskBase<AzureMonitorDiagnosticSettingsUpdateTask>
     {
        
        /// <summary>
        /// Update diagnostic settings.
        /// </summary>
        public AzureMonitorDiagnosticSettingsUpdateTask(string name = null ,  string resource = null)
        {
            WithArguments("az monitor diagnostic-settings update");
WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

WithArguments("--resource");
            if (!string.IsNullOrEmpty(resource))
            {
                 WithArguments(resource);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureMonitorDiagnosticSettingsUpdateTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// Target resource provider namespace.
        /// </summary>
        public AzureMonitorDiagnosticSettingsUpdateTask ResourceNamespace(string resourceNamespace = null)
        {
            WithArguments("--resource-namespace");
            if (!string.IsNullOrEmpty(resourceNamespace))
            {
                 WithArguments(resourceNamespace);
            }

            return this;
        }

        /// <summary>
        /// Target resource parent path, if applicable.
        /// </summary>
        public AzureMonitorDiagnosticSettingsUpdateTask ResourceParent(string resourceParent = null)
        {
            WithArguments("--resource-parent");
            if (!string.IsNullOrEmpty(resourceParent))
            {
                 WithArguments(resourceParent);
            }

            return this;
        }

        /// <summary>
        /// Target resource type. Can also accept namespace/type format (Ex: 'Microsoft.Compute/virtualMachines)').
        /// </summary>
        public AzureMonitorDiagnosticSettingsUpdateTask ResourceType(string resourceType = null)
        {
            WithArguments("--resource-type");
            if (!string.IsNullOrEmpty(resourceType))
            {
                 WithArguments(resourceType);
            }

            return this;
        }

        /// <summary>
        /// Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty <key=value, string or JSON string>.
        /// </summary>
        public AzureMonitorDiagnosticSettingsUpdateTask Add(string add = null)
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
        public AzureMonitorDiagnosticSettingsUpdateTask ForceString(string forceString = null)
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
        public AzureMonitorDiagnosticSettingsUpdateTask Remove(string remove = null)
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
        public AzureMonitorDiagnosticSettingsUpdateTask Set(string set = null)
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
