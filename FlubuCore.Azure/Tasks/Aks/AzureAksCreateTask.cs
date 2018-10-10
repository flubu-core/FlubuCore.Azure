
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Aks
{
     public partial class AzureAksCreateTask : ExternalProcessTaskBase<AzureAksCreateTask>
     {
        
        /// <summary>
        /// Create a new managed Kubernetes cluster.
        /// </summary>
        public AzureAksCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az aks create");
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
        /// (PREVIEW) The ID of an Azure Active Directory client application of type "Native". This application is for user login via kubectl.
        /// </summary>
        public AzureAksCreateTask AadClientAppId(string aadClientAppId = null)
        {
            WithArguments("--aad-client-app-id");
            if (!string.IsNullOrEmpty(aadClientAppId))
            {
                 WithArguments(aadClientAppId);
            }

            return this;
        }

        /// <summary>
        /// (PREVIEW) The ID of an Azure Active Directory server application of type "Web app/API". This application represents the managed cluster's apiserver (Server application).
        /// </summary>
        public AzureAksCreateTask AadServerAppId(string aadServerAppId = null)
        {
            WithArguments("--aad-server-app-id");
            if (!string.IsNullOrEmpty(aadServerAppId))
            {
                 WithArguments(aadServerAppId);
            }

            return this;
        }

        /// <summary>
        /// (PREVIEW) The secret of an Azure Active Directory server application.
        /// </summary>
        public AzureAksCreateTask AadServerAppSecret(string aadServerAppSecret = null)
        {
            WithArguments("--aad-server-app-secret");
            if (!string.IsNullOrEmpty(aadServerAppSecret))
            {
                 WithArguments(aadServerAppSecret);
            }

            return this;
        }

        /// <summary>
        /// (PREVIEW) The ID of an Azure Active Directory tenant.
        /// </summary>
        public AzureAksCreateTask AadTenantId(string aadTenantId = null)
        {
            WithArguments("--aad-tenant-id");
            if (!string.IsNullOrEmpty(aadTenantId))
            {
                 WithArguments(aadTenantId);
            }

            return this;
        }

        /// <summary>
        /// User account to create on node VMs for SSH access.
        /// </summary>
        public AzureAksCreateTask AdminUsername(string adminUsername = null)
        {
            WithArguments("--admin-username");
            if (!string.IsNullOrEmpty(adminUsername))
            {
                 WithArguments(adminUsername);
            }

            return this;
        }

        /// <summary>
        /// Secret associated with the service principal. This argument is required if `--service-principal` is specified.
        /// </summary>
        public AzureAksCreateTask ClientSecret(string clientSecret = null)
        {
            WithArguments("--client-secret");
            if (!string.IsNullOrEmpty(clientSecret))
            {
                 WithArguments(clientSecret);
            }

            return this;
        }

        /// <summary>
        /// Disable Kubernetes Role-Based Access Control.
        /// </summary>
        public AzureAksCreateTask DisableRbac(string disableRbac = null)
        {
            WithArguments("--disable-rbac");
            if (!string.IsNullOrEmpty(disableRbac))
            {
                 WithArguments(disableRbac);
            }

            return this;
        }

        /// <summary>
        /// Prefix for hostnames that are created. If not specified, generate a hostname using the managed cluster and resource group names.
        /// </summary>
        public AzureAksCreateTask DnsNamePrefix(string dnsNamePrefix = null)
        {
            WithArguments("--dns-name-prefix");
            if (!string.IsNullOrEmpty(dnsNamePrefix))
            {
                 WithArguments(dnsNamePrefix);
            }

            return this;
        }

        /// <summary>
        /// An IP address assigned to the Kubernetes DNS service.
        /// </summary>
        public AzureAksCreateTask DnsServiceIp(string dnsServiceIp = null)
        {
            WithArguments("--dns-service-ip");
            if (!string.IsNullOrEmpty(dnsServiceIp))
            {
                 WithArguments(dnsServiceIp);
            }

            return this;
        }

        /// <summary>
        /// An IP address and netmask assigned to the Docker bridge.
        /// </summary>
        public AzureAksCreateTask DockerBridgeAddress(string dockerBridgeAddress = null)
        {
            WithArguments("--docker-bridge-address");
            if (!string.IsNullOrEmpty(dockerBridgeAddress))
            {
                 WithArguments(dockerBridgeAddress);
            }

            return this;
        }

        /// <summary>
        /// Enable the Kubernetes addons in a comma-separated list.
        /// </summary>
        public AzureAksCreateTask EnableAddons(string enableAddons = null)
        {
            WithArguments("--enable-addons");
            if (!string.IsNullOrEmpty(enableAddons))
            {
                 WithArguments(enableAddons);
            }

            return this;
        }

        /// <summary>
        /// Enable Kubernetes Role-Based Access Control. Default: enabled.
        /// </summary>
        public AzureAksCreateTask EnableRbac(string enableRbac = null)
        {
            WithArguments("--enable-rbac");
            if (!string.IsNullOrEmpty(enableRbac))
            {
                 WithArguments(enableRbac);
            }

            return this;
        }

        /// <summary>
        /// Generate SSH public and private key files if missing.
        /// </summary>
        public AzureAksCreateTask GenerateSshKeys(string generateSshKeys = null)
        {
            WithArguments("--generate-ssh-keys");
            if (!string.IsNullOrEmpty(generateSshKeys))
            {
                 WithArguments(generateSshKeys);
            }

            return this;
        }

        /// <summary>
        /// Version of Kubernetes to use for creating the cluster, such as "1.7.12" or "1.8.7".
        /// </summary>
        public AzureAksCreateTask KubernetesVersion(string kubernetesVersion = null)
        {
            WithArguments("--kubernetes-version");
            if (!string.IsNullOrEmpty(kubernetesVersion))
            {
                 WithArguments(kubernetesVersion);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureAksCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// The maximum number of pods deployable to a node.
        /// </summary>
        public AzureAksCreateTask MaxPods(string maxPods = null)
        {
            WithArguments("--max-pods");
            if (!string.IsNullOrEmpty(maxPods))
            {
                 WithArguments(maxPods);
            }

            return this;
        }

        /// <summary>
        /// The Kubernetes network plugin to use.
        /// </summary>
        public AzureAksCreateTask NetworkPlugin(string networkPlugin = null)
        {
            WithArguments("--network-plugin");
            if (!string.IsNullOrEmpty(networkPlugin))
            {
                 WithArguments(networkPlugin);
            }

            return this;
        }

        /// <summary>
        /// Do not use or create a local SSH key.
        /// </summary>
        public AzureAksCreateTask NoSshKey(string noSshKey = null)
        {
            WithArguments("--no-ssh-key");
            if (!string.IsNullOrEmpty(noSshKey))
            {
                 WithArguments(noSshKey);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureAksCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Number of nodes in the Kubernetes node pool. After creating a cluster, you can change the size of its node pool with `az aks scale`.
        /// </summary>
        public AzureAksCreateTask NodeCount(string nodeCount = null)
        {
            WithArguments("--node-count");
            if (!string.IsNullOrEmpty(nodeCount))
            {
                 WithArguments(nodeCount);
            }

            return this;
        }

        /// <summary>
        /// Size in GB of the OS disk for each node in the node pool. Minimum 30 GB.
        /// </summary>
        public AzureAksCreateTask NodeOsdiskSize(string nodeOsdiskSize = null)
        {
            WithArguments("--node-osdisk-size");
            if (!string.IsNullOrEmpty(nodeOsdiskSize))
            {
                 WithArguments(nodeOsdiskSize);
            }

            return this;
        }

        /// <summary>
        /// Size of Virtual Machines to create as Kubernetes nodes.
        /// </summary>
        public AzureAksCreateTask NodeVmSize(string nodeVmSize = null)
        {
            WithArguments("--node-vm-size");
            if (!string.IsNullOrEmpty(nodeVmSize))
            {
                 WithArguments(nodeVmSize);
            }

            return this;
        }

        /// <summary>
        /// A CIDR notation IP range from which to assign pod IPs when kubenet is used.
        /// </summary>
        public AzureAksCreateTask PodCidr(string podCidr = null)
        {
            WithArguments("--pod-cidr");
            if (!string.IsNullOrEmpty(podCidr))
            {
                 WithArguments(podCidr);
            }

            return this;
        }

        /// <summary>
        /// A CIDR notation IP range from which to assign service cluster IPs.
        /// </summary>
        public AzureAksCreateTask ServiceCidr(string serviceCidr = null)
        {
            WithArguments("--service-cidr");
            if (!string.IsNullOrEmpty(serviceCidr))
            {
                 WithArguments(serviceCidr);
            }

            return this;
        }

        /// <summary>
        /// Service principal used for authentication to Azure APIs.
        /// </summary>
        public AzureAksCreateTask ServicePrincipal(string servicePrincipal = null)
        {
            WithArguments("--service-principal");
            if (!string.IsNullOrEmpty(servicePrincipal))
            {
                 WithArguments(servicePrincipal);
            }

            return this;
        }

        /// <summary>
        /// Skip role assignment for subnet (advanced networking).
        /// </summary>
        public AzureAksCreateTask SkipSubnetRoleAssignment(string skipSubnetRoleAssignment = null)
        {
            WithArguments("--skip-subnet-role-assignment");
            if (!string.IsNullOrEmpty(skipSubnetRoleAssignment))
            {
                 WithArguments(skipSubnetRoleAssignment);
            }

            return this;
        }

        /// <summary>
        /// Public key path or key contents to install on node VMs for SSH access. For example, 'ssh-rsa AAAAB...snip...UcyupgH azureuser@linuxvm'.
        /// </summary>
        public AzureAksCreateTask SshKeyValue(string sshKeyValue = null)
        {
            WithArguments("--ssh-key-value");
            if (!string.IsNullOrEmpty(sshKeyValue))
            {
                 WithArguments(sshKeyValue);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureAksCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// The ID of a subnet in an existing VNet into which to deploy the cluster.
        /// </summary>
        public AzureAksCreateTask VnetSubnetId(string vnetSubnetId = null)
        {
            WithArguments("--vnet-subnet-id");
            if (!string.IsNullOrEmpty(vnetSubnetId))
            {
                 WithArguments(vnetSubnetId);
            }

            return this;
        }

        /// <summary>
        /// The resource ID of an existing Log Analytics Workspace to use for storing monitoring data. If not specified, uses the default Log Analytics Workspace if it exists, otherwise creates one.
        /// </summary>
        public AzureAksCreateTask WorkspaceResourceId(string workspaceResourceId = null)
        {
            WithArguments("--workspace-resource-id");
            if (!string.IsNullOrEmpty(workspaceResourceId))
            {
                 WithArguments(workspaceResourceId);
            }

            return this;
        }
     }
}
