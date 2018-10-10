
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Aks
{
     public partial class AzureAksRemoveConnectorTask : ExternalProcessTaskBase<AzureAksRemoveConnectorTask>
     {
        
        /// <summary>
        /// (PREVIEW) Remove the ACI Connector from a managed Kubernetes cluster.
        /// </summary>
        public AzureAksRemoveConnectorTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az aks remove-connector");
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
        /// Name of the ACI Connector.
        /// </summary>
        public AzureAksRemoveConnectorTask ConnectorName(string connectorName = null)
        {
            WithArguments("--connector-name");
            if (!string.IsNullOrEmpty(connectorName))
            {
                 WithArguments(connectorName);
            }

            return this;
        }

        /// <summary>
        /// Use a "cordon and drain" strategy to evict pods safely before removing the ACI node.
        /// </summary>
        public AzureAksRemoveConnectorTask Graceful(string graceful = null)
        {
            WithArguments("--graceful");
            if (!string.IsNullOrEmpty(graceful))
            {
                 WithArguments(graceful);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureAksRemoveConnectorTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Remove support for deploying ACIs of this operating system type.
        /// </summary>
        public AzureAksRemoveConnectorTask OsType(string osType = null)
        {
            WithArguments("--os-type");
            if (!string.IsNullOrEmpty(osType))
            {
                 WithArguments(osType);
            }

            return this;
        }
     }
}
