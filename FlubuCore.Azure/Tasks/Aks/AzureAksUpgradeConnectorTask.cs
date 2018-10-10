
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Aks
{
     public partial class AzureAksUpgradeConnectorTask : ExternalProcessTaskBase<AzureAksUpgradeConnectorTask>
     {
        
        /// <summary>
        /// (PREVIEW) Upgrade the ACI Connector on a managed Kubernetes cluster.
        /// </summary>
        public AzureAksUpgradeConnectorTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az aks upgrade-connector");
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
        /// The resource group to create the ACI container groups. Use the MC_* resource group if it is not specified.
        /// </summary>
        public AzureAksUpgradeConnectorTask AciResourceGroup(string aciResourceGroup = null)
        {
            WithArguments("--aci-resource-group");
            if (!string.IsNullOrEmpty(aciResourceGroup))
            {
                 WithArguments(aciResourceGroup);
            }

            return this;
        }

        /// <summary>
        /// URL of a Helm chart that installs ACI Connector.
        /// </summary>
        public AzureAksUpgradeConnectorTask ChartUrl(string chartUrl = null)
        {
            WithArguments("--chart-url");
            if (!string.IsNullOrEmpty(chartUrl))
            {
                 WithArguments(chartUrl);
            }

            return this;
        }

        /// <summary>
        /// Secret associated with the service principal. This argument is required if `--service-principal` is specified.
        /// </summary>
        public AzureAksUpgradeConnectorTask ClientSecret(string clientSecret = null)
        {
            WithArguments("--client-secret");
            if (!string.IsNullOrEmpty(clientSecret))
            {
                 WithArguments(clientSecret);
            }

            return this;
        }

        /// <summary>
        /// Name of the ACI Connector.
        /// </summary>
        public AzureAksUpgradeConnectorTask ConnectorName(string connectorName = null)
        {
            WithArguments("--connector-name");
            if (!string.IsNullOrEmpty(connectorName))
            {
                 WithArguments(connectorName);
            }

            return this;
        }

        /// <summary>
        /// The image tag of the virtual kubelet. Use 'latest' if it is not specified.
        /// </summary>
        public AzureAksUpgradeConnectorTask ImageTag(string imageTag = null)
        {
            WithArguments("--image-tag");
            if (!string.IsNullOrEmpty(imageTag))
            {
                 WithArguments(imageTag);
            }

            return this;
        }

        /// <summary>
        /// The location to create the ACI container groups. Use the location of the MC_* resource group if it is not specified.
        /// </summary>
        public AzureAksUpgradeConnectorTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Install support for deploying ACIs of this operating system type.
        /// </summary>
        public AzureAksUpgradeConnectorTask OsType(string osType = null)
        {
            WithArguments("--os-type");
            if (!string.IsNullOrEmpty(osType))
            {
                 WithArguments(osType);
            }

            return this;
        }

        /// <summary>
        /// Service principal used for authentication to Azure APIs.
        /// </summary>
        public AzureAksUpgradeConnectorTask ServicePrincipal(string servicePrincipal = null)
        {
            WithArguments("--service-principal");
            if (!string.IsNullOrEmpty(servicePrincipal))
            {
                 WithArguments(servicePrincipal);
            }

            return this;
        }
     }
}
