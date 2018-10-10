
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Container
{
     public partial class AzureContainerCreateTask : ExternalProcessTaskBase<AzureContainerCreateTask>
     {
        
        /// <summary>
        /// Create a container group.
        /// </summary>
        public AzureContainerCreateTask(string resourceGroup = null)
        {
            WithArguments("az container create");
WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The command line to run when the container is started, e.g. '/bin/bash -c myscript.sh'.
        /// </summary>
        public AzureContainerCreateTask CommandLine(string commandLine = null)
        {
            WithArguments("--command-line");
            if (!string.IsNullOrEmpty(commandLine))
            {
                 WithArguments(commandLine);
            }

            return this;
        }

        /// <summary>
        /// The required number of CPU cores of the containers.
        /// </summary>
        public AzureContainerCreateTask Cpu(string cpu = null)
        {
            WithArguments("--cpu");
            if (!string.IsNullOrEmpty(cpu))
            {
                 WithArguments(cpu);
            }

            return this;
        }

        /// <summary>
        /// The dns name label for container group with public IP.
        /// </summary>
        public AzureContainerCreateTask DnsNameLabel(string dnsNameLabel = null)
        {
            WithArguments("--dns-name-label");
            if (!string.IsNullOrEmpty(dnsNameLabel))
            {
                 WithArguments(dnsNameLabel);
            }

            return this;
        }

        /// <summary>
        /// A list of environment variable for the container. Space-separated values in 'key=value' format.
        /// </summary>
        public AzureContainerCreateTask EnvironmentVariables(string environmentVariables = null)
        {
            WithArguments("--environment-variables");
            if (!string.IsNullOrEmpty(environmentVariables))
            {
                 WithArguments(environmentVariables);
            }

            return this;
        }

        /// <summary>
        /// The path to the input file.
        /// </summary>
        public AzureContainerCreateTask File(string file = null)
        {
            WithArguments("--file");
            if (!string.IsNullOrEmpty(file))
            {
                 WithArguments(file);
            }

            return this;
        }

        /// <summary>
        /// The container image name.
        /// </summary>
        public AzureContainerCreateTask Image(string image = null)
        {
            WithArguments("--image");
            if (!string.IsNullOrEmpty(image))
            {
                 WithArguments(image);
            }

            return this;
        }

        /// <summary>
        /// The IP address type of the container group.
        /// </summary>
        public AzureContainerCreateTask IpAddress(string ipAddress = null)
        {
            WithArguments("--ip-address");
            if (!string.IsNullOrEmpty(ipAddress))
            {
                 WithArguments(ipAddress);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureContainerCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// The required memory of the containers in GB.
        /// </summary>
        public AzureContainerCreateTask Memory(string memory = null)
        {
            WithArguments("--memory");
            if (!string.IsNullOrEmpty(memory))
            {
                 WithArguments(memory);
            }

            return this;
        }

        /// <summary>
        /// The name of the container group.
        /// </summary>
        public AzureContainerCreateTask Name(string name = null)
        {
            WithArguments("--name");
            if (!string.IsNullOrEmpty(name))
            {
                 WithArguments(name);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureContainerCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// The OS type of the containers.
        /// </summary>
        public AzureContainerCreateTask OsType(string osType = null)
        {
            WithArguments("--os-type");
            if (!string.IsNullOrEmpty(osType))
            {
                 WithArguments(osType);
            }

            return this;
        }

        /// <summary>
        /// The ports to open.
        /// </summary>
        public AzureContainerCreateTask Ports(string ports = null)
        {
            WithArguments("--ports");
            if (!string.IsNullOrEmpty(ports))
            {
                 WithArguments(ports);
            }

            return this;
        }

        /// <summary>
        /// The network protocol to use.
        /// </summary>
        public AzureContainerCreateTask Protocol(string protocol = null)
        {
            WithArguments("--protocol");
            if (!string.IsNullOrEmpty(protocol))
            {
                 WithArguments(protocol);
            }

            return this;
        }

        /// <summary>
        /// Restart policy for all containers within the container group.
        /// </summary>
        public AzureContainerCreateTask RestartPolicy(string restartPolicy = null)
        {
            WithArguments("--restart-policy");
            if (!string.IsNullOrEmpty(restartPolicy))
            {
                 WithArguments(restartPolicy);
            }

            return this;
        }

        /// <summary>
        /// Space-separated secrets in 'key=value' format.
        /// </summary>
        public AzureContainerCreateTask Secrets(string secrets = null)
        {
            WithArguments("--secrets");
            if (!string.IsNullOrEmpty(secrets))
            {
                 WithArguments(secrets);
            }

            return this;
        }

        /// <summary>
        /// The path within the container where the secrets volume should be mounted. Must not contain colon ':'.
        /// </summary>
        public AzureContainerCreateTask SecretsMountPath(string secretsMountPath = null)
        {
            WithArguments("--secrets-mount-path");
            if (!string.IsNullOrEmpty(secretsMountPath))
            {
                 WithArguments(secretsMountPath);
            }

            return this;
        }

        /// <summary>
        /// A list of secure environment variable for the container. Space-separated values in 'key=value' format.
        /// </summary>
        public AzureContainerCreateTask SecureEnvironmentVariables(string secureEnvironmentVariables = null)
        {
            WithArguments("--secure-environment-variables");
            if (!string.IsNullOrEmpty(secureEnvironmentVariables))
            {
                 WithArguments(secureEnvironmentVariables);
            }

            return this;
        }

        /// <summary>
        /// The storage account access key used to access the Azure File share.
        /// </summary>
        public AzureContainerCreateTask AzureFileVolumeAccountKey(string azureFileVolumeAccountKey = null)
        {
            WithArguments("--azure-file-volume-account-key");
            if (!string.IsNullOrEmpty(azureFileVolumeAccountKey))
            {
                 WithArguments(azureFileVolumeAccountKey);
            }

            return this;
        }

        /// <summary>
        /// The name of the storage account that contains the Azure File share.
        /// </summary>
        public AzureContainerCreateTask AzureFileVolumeAccountName(string azureFileVolumeAccountName = null)
        {
            WithArguments("--azure-file-volume-account-name");
            if (!string.IsNullOrEmpty(azureFileVolumeAccountName))
            {
                 WithArguments(azureFileVolumeAccountName);
            }

            return this;
        }

        /// <summary>
        /// The path within the container where the azure file volume should be mounted. Must not contain colon ':'.
        /// </summary>
        public AzureContainerCreateTask AzureFileVolumeMountPath(string azureFileVolumeMountPath = null)
        {
            WithArguments("--azure-file-volume-mount-path");
            if (!string.IsNullOrEmpty(azureFileVolumeMountPath))
            {
                 WithArguments(azureFileVolumeMountPath);
            }

            return this;
        }

        /// <summary>
        /// The name of the Azure File share to be mounted as a volume.
        /// </summary>
        public AzureContainerCreateTask AzureFileVolumeShareName(string azureFileVolumeShareName = null)
        {
            WithArguments("--azure-file-volume-share-name");
            if (!string.IsNullOrEmpty(azureFileVolumeShareName))
            {
                 WithArguments(azureFileVolumeShareName);
            }

            return this;
        }

        /// <summary>
        /// The target directory path in the git repository. Must not contain '..'.
        /// </summary>
        public AzureContainerCreateTask GitrepoDir(string gitrepoDir = null)
        {
            WithArguments("--gitrepo-dir");
            if (!string.IsNullOrEmpty(gitrepoDir))
            {
                 WithArguments(gitrepoDir);
            }

            return this;
        }

        /// <summary>
        /// The path within the container where the git repo volume should be mounted. Must not contain colon ':'.
        /// </summary>
        public AzureContainerCreateTask GitrepoMountPath(string gitrepoMountPath = null)
        {
            WithArguments("--gitrepo-mount-path");
            if (!string.IsNullOrEmpty(gitrepoMountPath))
            {
                 WithArguments(gitrepoMountPath);
            }

            return this;
        }

        /// <summary>
        /// The commit hash for the specified revision.
        /// </summary>
        public AzureContainerCreateTask GitrepoRevision(string gitrepoRevision = null)
        {
            WithArguments("--gitrepo-revision");
            if (!string.IsNullOrEmpty(gitrepoRevision))
            {
                 WithArguments(gitrepoRevision);
            }

            return this;
        }

        /// <summary>
        /// The URL of a git repository to be mounted as a volume.
        /// </summary>
        public AzureContainerCreateTask GitrepoUrl(string gitrepoUrl = null)
        {
            WithArguments("--gitrepo-url");
            if (!string.IsNullOrEmpty(gitrepoUrl))
            {
                 WithArguments(gitrepoUrl);
            }

            return this;
        }

        /// <summary>
        /// The container image registry login server.
        /// </summary>
        public AzureContainerCreateTask RegistryLoginServer(string registryLoginServer = null)
        {
            WithArguments("--registry-login-server");
            if (!string.IsNullOrEmpty(registryLoginServer))
            {
                 WithArguments(registryLoginServer);
            }

            return this;
        }

        /// <summary>
        /// The password to log in container image registry server.
        /// </summary>
        public AzureContainerCreateTask RegistryPassword(string registryPassword = null)
        {
            WithArguments("--registry-password");
            if (!string.IsNullOrEmpty(registryPassword))
            {
                 WithArguments(registryPassword);
            }

            return this;
        }

        /// <summary>
        /// The username to log in container image registry server.
        /// </summary>
        public AzureContainerCreateTask RegistryUsername(string registryUsername = null)
        {
            WithArguments("--registry-username");
            if (!string.IsNullOrEmpty(registryUsername))
            {
                 WithArguments(registryUsername);
            }

            return this;
        }

        /// <summary>
        /// The Log Analytics workspace name or id. Use the current subscription or use --subscription flag to set the desired subscription.
        /// </summary>
        public AzureContainerCreateTask LogAnalyticsWorkspace(string logAnalyticsWorkspace = null)
        {
            WithArguments("--log-analytics-workspace");
            if (!string.IsNullOrEmpty(logAnalyticsWorkspace))
            {
                 WithArguments(logAnalyticsWorkspace);
            }

            return this;
        }

        /// <summary>
        /// The Log Analytics workspace key.
        /// </summary>
        public AzureContainerCreateTask LogAnalyticsWorkspaceKey(string logAnalyticsWorkspaceKey = null)
        {
            WithArguments("--log-analytics-workspace-key");
            if (!string.IsNullOrEmpty(logAnalyticsWorkspaceKey))
            {
                 WithArguments(logAnalyticsWorkspaceKey);
            }

            return this;
        }

        /// <summary>
        /// The network profile name or id.
        /// </summary>
        public AzureContainerCreateTask NetworkProfile(string networkProfile = null)
        {
            WithArguments("--network-profile");
            if (!string.IsNullOrEmpty(networkProfile))
            {
                 WithArguments(networkProfile);
            }

            return this;
        }

        /// <summary>
        /// The name of the subnet when creating a new VNET or referencing an existing one. Can also reference an existing subnet by ID.
        /// </summary>
        public AzureContainerCreateTask Subnet(string subnet = null)
        {
            WithArguments("--subnet");
            if (!string.IsNullOrEmpty(subnet))
            {
                 WithArguments(subnet);
            }

            return this;
        }

        /// <summary>
        /// The subnet IP address prefix to use when creating a new VNET in CIDR format.
        /// </summary>
        public AzureContainerCreateTask SubnetAddressPrefix(string subnetAddressPrefix = null)
        {
            WithArguments("--subnet-address-prefix");
            if (!string.IsNullOrEmpty(subnetAddressPrefix))
            {
                 WithArguments(subnetAddressPrefix);
            }

            return this;
        }

        /// <summary>
        /// The IP address prefix to use when creating a new VNET in CIDR format.
        /// </summary>
        public AzureContainerCreateTask VnetAddressPrefix(string vnetAddressPrefix = null)
        {
            WithArguments("--vnet-address-prefix");
            if (!string.IsNullOrEmpty(vnetAddressPrefix))
            {
                 WithArguments(vnetAddressPrefix);
            }

            return this;
        }

        /// <summary>
        /// The name of the VNET when creating a new one or referencing an existing one.
        /// </summary>
        public AzureContainerCreateTask VnetName(string vnetName = null)
        {
            WithArguments("--vnet-name");
            if (!string.IsNullOrEmpty(vnetName))
            {
                 WithArguments(vnetName);
            }

            return this;
        }
     }
}
