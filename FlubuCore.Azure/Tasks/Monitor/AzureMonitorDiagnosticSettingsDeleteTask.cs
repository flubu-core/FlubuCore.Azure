
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorDiagnosticSettingsDeleteTask : ExternalProcessTaskBase<AzureMonitorDiagnosticSettingsDeleteTask>
     {
        
        /// <summary>
        /// Deletes existing diagnostic settings for the specified resource.
        /// </summary>
        public AzureMonitorDiagnosticSettingsDeleteTask(string name = null ,  string resource = null)
        {
            WithArguments("az monitor diagnostic-settings delete");
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
        public AzureMonitorDiagnosticSettingsDeleteTask ResourceGroup(string resourceGroup = null)
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
        public AzureMonitorDiagnosticSettingsDeleteTask ResourceNamespace(string resourceNamespace = null)
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
        public AzureMonitorDiagnosticSettingsDeleteTask ResourceParent(string resourceParent = null)
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
        public AzureMonitorDiagnosticSettingsDeleteTask ResourceType(string resourceType = null)
        {
            WithArguments("--resource-type");
            if (!string.IsNullOrEmpty(resourceType))
            {
                 WithArguments(resourceType);
            }

            return this;
        }
     }
}
