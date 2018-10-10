
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Network
{
     public partial class AzureNetworkWatcherRunConfigurationDiagnosticTask : ExternalProcessTaskBase<AzureNetworkWatcherRunConfigurationDiagnosticTask>
     {
        
        /// <summary>
        /// Run a configuration diagnostic on a target resource.
        /// </summary>
        public AzureNetworkWatcherRunConfigurationDiagnosticTask(string resource = null)
        {
            WithArguments("az network watcher run-configuration-diagnostic");
WithArguments("--resource");
            if (!string.IsNullOrEmpty(resource))
            {
                 WithArguments(resource);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Traffic destination. Accepted values are '*', IP address/CIDR, or service tag.
        /// </summary>
        public AzureNetworkWatcherRunConfigurationDiagnosticTask Destination(string destination = null)
        {
            WithArguments("--destination");
            if (!string.IsNullOrEmpty(destination))
            {
                 WithArguments(destination);
            }

            return this;
        }

        /// <summary>
        /// Direction of the traffic.
        /// </summary>
        public AzureNetworkWatcherRunConfigurationDiagnosticTask Direction(string direction = null)
        {
            WithArguments("--direction");
            if (!string.IsNullOrEmpty(direction))
            {
                 WithArguments(direction);
            }

            return this;
        }

        /// <summary>
        /// Traffic destination port. Accepted values are '*', port number (3389) or port range (80-100).
        /// </summary>
        public AzureNetworkWatcherRunConfigurationDiagnosticTask Port(string port = null)
        {
            WithArguments("--port");
            if (!string.IsNullOrEmpty(port))
            {
                 WithArguments(port);
            }

            return this;
        }

        /// <summary>
        /// Protocol to be verified on.
        /// </summary>
        public AzureNetworkWatcherRunConfigurationDiagnosticTask Protocol(string protocol = null)
        {
            WithArguments("--protocol");
            if (!string.IsNullOrEmpty(protocol))
            {
                 WithArguments(protocol);
            }

            return this;
        }

        /// <summary>
        /// JSON list of queries to use. Use `@{path}` to load from a file.
        /// </summary>
        public AzureNetworkWatcherRunConfigurationDiagnosticTask Queries(string queries = null)
        {
            WithArguments("--queries");
            if (!string.IsNullOrEmpty(queries))
            {
                 WithArguments(queries);
            }

            return this;
        }

        /// <summary>
        /// Traffic source. Accepted values are '*', IP address/CIDR, or service tag.
        /// </summary>
        public AzureNetworkWatcherRunConfigurationDiagnosticTask Source(string source = null)
        {
            WithArguments("--source");
            if (!string.IsNullOrEmpty(source))
            {
                 WithArguments(source);
            }

            return this;
        }

        /// <summary>
        /// The parent path. (ex: virtualMachineScaleSets/vmss1).
        /// </summary>
        public AzureNetworkWatcherRunConfigurationDiagnosticTask Parent(string parent = null)
        {
            WithArguments("--parent");
            if (!string.IsNullOrEmpty(parent))
            {
                 WithArguments(parent);
            }

            return this;
        }

        /// <summary>
        /// Name of resource group. You can configure the default group using `az configure --defaults group=&lt;name&gt;`.
        /// </summary>
        public AzureNetworkWatcherRunConfigurationDiagnosticTask ResourceGroup(string resourceGroup = null)
        {
            WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

            return this;
        }

        /// <summary>
        /// The resource type.
        /// </summary>
        public AzureNetworkWatcherRunConfigurationDiagnosticTask ResourceType(string resourceType = null)
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
