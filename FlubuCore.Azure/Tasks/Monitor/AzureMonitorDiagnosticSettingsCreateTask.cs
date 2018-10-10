
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Monitor
{
     public partial class AzureMonitorDiagnosticSettingsCreateTask : ExternalProcessTaskBase<AzureMonitorDiagnosticSettingsCreateTask>
     {
        
        /// <summary>
        /// Create diagnostic settings for the specified resource.
        /// </summary>
        public AzureMonitorDiagnosticSettingsCreateTask(string name = null ,  string resource = null)
        {
            WithArguments("az monitor diagnostic-settings create");
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
        /// The name of the event hub. If none is specified, the default event hub will be selected.
        /// </summary>
        public AzureMonitorDiagnosticSettingsCreateTask EventHub(string eventHub = null)
        {
            WithArguments("--event-hub");
            if (!string.IsNullOrEmpty(eventHub))
            {
                 WithArguments(eventHub);
            }

            return this;
        }

        /// <summary>
        /// The resource Id for the event hub authorization rule.
        /// </summary>
        public AzureMonitorDiagnosticSettingsCreateTask EventHubRule(string eventHubRule = null)
        {
            WithArguments("--event-hub-rule");
            if (!string.IsNullOrEmpty(eventHubRule))
            {
                 WithArguments(eventHubRule);
            }

            return this;
        }

        /// <summary>
        /// JSON encoded list of logs settings. Use '@{file}' to load from a file.
        /// </summary>
        public AzureMonitorDiagnosticSettingsCreateTask Logs(string logs = null)
        {
            WithArguments("--logs");
            if (!string.IsNullOrEmpty(logs))
            {
                 WithArguments(logs);
            }

            return this;
        }

        /// <summary>
        /// JSON encoded list of metric settings. Use '@{file}' to load from a file.
        /// </summary>
        public AzureMonitorDiagnosticSettingsCreateTask Metrics(string metrics = null)
        {
            WithArguments("--metrics");
            if (!string.IsNullOrEmpty(metrics))
            {
                 WithArguments(metrics);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of the storage account to send diagnostic logs to.
        /// </summary>
        public AzureMonitorDiagnosticSettingsCreateTask StorageAccount(string storageAccount = null)
        {
            WithArguments("--storage-account");
            if (!string.IsNullOrEmpty(storageAccount))
            {
                 WithArguments(storageAccount);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of the Log Analytics workspace to send diagnostic logs to.
        /// </summary>
        public AzureMonitorDiagnosticSettingsCreateTask Workspace(string workspace = null)
        {
            WithArguments("--workspace");
            if (!string.IsNullOrEmpty(workspace))
            {
                 WithArguments(workspace);
            }

            return this;
        }

        /// <summary>
        /// Name of the resource group for the Log Analytics and Storage Account when the name of the service instead of a full resource ID is given.
        /// </summary>
        public AzureMonitorDiagnosticSettingsCreateTask ResourceGroup(string resourceGroup = null)
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
        public AzureMonitorDiagnosticSettingsCreateTask ResourceNamespace(string resourceNamespace = null)
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
        public AzureMonitorDiagnosticSettingsCreateTask ResourceParent(string resourceParent = null)
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
        public AzureMonitorDiagnosticSettingsCreateTask ResourceType(string resourceType = null)
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
