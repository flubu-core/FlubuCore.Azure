
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Acs
{
     public partial class AzureAcsCreateTask : ExternalProcessTaskBase<AzureAcsCreateTask>
     {
        
        /// <summary>
        /// Create a container service.
        /// </summary>
        public AzureAcsCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az acs create");
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
        /// The adminstration password for Windows nodes. Only available if --windows=true.
        /// </summary>
        public AzureAcsCreateTask AdminPassword(string adminPassword = null)
        {
            WithArguments("--admin-password");
            if (!string.IsNullOrEmpty(adminPassword))
            {
                 WithArguments(adminPassword);
            }

            return this;
        }

        /// <summary>
        /// User name for the Linux Virtual Machines.
        /// </summary>
        public AzureAcsCreateTask AdminUsername(string adminUsername = null)
        {
            WithArguments("--admin-username");
            if (!string.IsNullOrEmpty(adminUsername))
            {
                 WithArguments(adminUsername);
            }

            return this;
        }

        public AzureAcsCreateTask AgentCount(string agentCount = null)
        {
            WithArguments("--agent-count");
            if (!string.IsNullOrEmpty(agentCount))
            {
                 WithArguments(agentCount);
            }

            return this;
        }

        /// <summary>
        /// Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set the default disk size for agent pools vms. Unit in GB. Default: corresponding vmsize disk size.
        /// </summary>
        public AzureAcsCreateTask AgentOsdiskSize(string agentOsdiskSize = null)
        {
            WithArguments("--agent-osdisk-size");
            if (!string.IsNullOrEmpty(agentOsdiskSize))
            {
                 WithArguments(agentOsdiskSize);
            }

            return this;
        }

        /// <summary>
        /// Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set the default ports exposed on the agent pools. Only usable for non-Kubernetes. Default: 8080,4000,80.
        /// </summary>
        public AzureAcsCreateTask AgentPorts(string agentPorts = null)
        {
            WithArguments("--agent-ports");
            if (!string.IsNullOrEmpty(agentPorts))
            {
                 WithArguments(agentPorts);
            }

            return this;
        }

        /// <summary>
        /// Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The file or dictionary representation of the agent profiles. Note it will override any agent settings once set.
        /// </summary>
        public AzureAcsCreateTask AgentProfiles(string agentProfiles = null)
        {
            WithArguments("--agent-profiles");
            if (!string.IsNullOrEmpty(agentProfiles))
            {
                 WithArguments(agentProfiles);
            }

            return this;
        }

        /// <summary>
        /// Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set default storage profile for agent pools. Default: varies based on Orchestrator.
        /// </summary>
        public AzureAcsCreateTask AgentStorageProfile(string agentStorageProfile = null)
        {
            WithArguments("--agent-storage-profile");
            if (!string.IsNullOrEmpty(agentStorageProfile))
            {
                 WithArguments(agentStorageProfile);
            }

            return this;
        }

        /// <summary>
        /// Set the default size for agent pools vms.
        /// </summary>
        public AzureAcsCreateTask AgentVmSize(string agentVmSize = null)
        {
            WithArguments("--agent-vm-size");
            if (!string.IsNullOrEmpty(agentVmSize))
            {
                 WithArguments(agentVmSize);
            }

            return this;
        }

        /// <summary>
        /// Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set the default custom vnet subnet id for agent pools. Note agent need to used the same vnet if master set. Default: "".
        /// </summary>
        public AzureAcsCreateTask AgentVnetSubnetId(string agentVnetSubnetId = null)
        {
            WithArguments("--agent-vnet-subnet-id");
            if (!string.IsNullOrEmpty(agentVnetSubnetId))
            {
                 WithArguments(agentVnetSubnetId);
            }

            return this;
        }

        /// <summary>
        /// Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Use API version of ACS to perform az acs operations. Available options: 2017-01-31, 2017-07-01. Default: the latest version for the location.
        /// </summary>
        public AzureAcsCreateTask ApiVersion(string apiVersion = null)
        {
            WithArguments("--api-version");
            if (!string.IsNullOrEmpty(apiVersion))
            {
                 WithArguments(apiVersion);
            }

            return this;
        }

        public AzureAcsCreateTask ClientSecret(string clientSecret = null)
        {
            WithArguments("--client-secret");
            if (!string.IsNullOrEmpty(clientSecret))
            {
                 WithArguments(clientSecret);
            }

            return this;
        }

        /// <summary>
        /// Sets the Domain name prefix for the cluster. The concatenation of the domain name and the regionalized DNS zone make up the fully qualified domain name associated with the public IP address.
        /// </summary>
        public AzureAcsCreateTask DnsPrefix(string dnsPrefix = null)
        {
            WithArguments("--dns-prefix");
            if (!string.IsNullOrEmpty(dnsPrefix))
            {
                 WithArguments(dnsPrefix);
            }

            return this;
        }

        /// <summary>
        /// Generate SSH public and private key files if missing.
        /// </summary>
        public AzureAcsCreateTask GenerateSshKeys(string generateSshKeys = null)
        {
            WithArguments("--generate-ssh-keys");
            if (!string.IsNullOrEmpty(generateSshKeys))
            {
                 WithArguments(generateSshKeys);
            }

            return this;
        }

        /// <summary>
        /// Location. You can configure the default location using `az configure --defaults location=&lt;location&gt;`.
        /// </summary>
        public AzureAcsCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// The number of masters for the cluster.
        /// </summary>
        public AzureAcsCreateTask MasterCount(string masterCount = null)
        {
            WithArguments("--master-count");
            if (!string.IsNullOrEmpty(masterCount))
            {
                 WithArguments(masterCount);
            }

            return this;
        }

        /// <summary>
        /// Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The first consecutive ip used to specify static ip block.
        /// </summary>
        public AzureAcsCreateTask MasterFirstConsecutiveStaticIp(string masterFirstConsecutiveStaticIp = null)
        {
            WithArguments("--master-first-consecutive-static-ip");
            if (!string.IsNullOrEmpty(masterFirstConsecutiveStaticIp))
            {
                 WithArguments(masterFirstConsecutiveStaticIp);
            }

            return this;
        }

        /// <summary>
        /// Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The disk size for master pool vms. Unit in GB. Default: corresponding vmsize disk size.
        /// </summary>
        public AzureAcsCreateTask MasterOsdiskSize(string masterOsdiskSize = null)
        {
            WithArguments("--master-osdisk-size");
            if (!string.IsNullOrEmpty(masterOsdiskSize))
            {
                 WithArguments(masterOsdiskSize);
            }

            return this;
        }

        /// <summary>
        /// Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The file or dictionary representation of the master profile. Note it will override any master settings once set.
        /// </summary>
        public AzureAcsCreateTask MasterProfile(string masterProfile = null)
        {
            WithArguments("--master-profile");
            if (!string.IsNullOrEmpty(masterProfile))
            {
                 WithArguments(masterProfile);
            }

            return this;
        }

        /// <summary>
        /// Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Default: varies based on Orchestrator.
        /// </summary>
        public AzureAcsCreateTask MasterStorageProfile(string masterStorageProfile = null)
        {
            WithArguments("--master-storage-profile");
            if (!string.IsNullOrEmpty(masterStorageProfile))
            {
                 WithArguments(masterStorageProfile);
            }

            return this;
        }

        /// <summary>
        /// Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2.
        /// </summary>
        public AzureAcsCreateTask MasterVmSize(string masterVmSize = null)
        {
            WithArguments("--master-vm-size");
            if (!string.IsNullOrEmpty(masterVmSize))
            {
                 WithArguments(masterVmSize);
            }

            return this;
        }

        /// <summary>
        /// Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The custom vnet subnet id. Note agent need to used the same vnet if master set. Default: "".
        /// </summary>
        public AzureAcsCreateTask MasterVnetSubnetId(string masterVnetSubnetId = null)
        {
            WithArguments("--master-vnet-subnet-id");
            if (!string.IsNullOrEmpty(masterVnetSubnetId))
            {
                 WithArguments(masterVnetSubnetId);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureAcsCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// The type of orchestrator used to manage the applications on the cluster.
        /// </summary>
        public AzureAcsCreateTask OrchestratorType(string orchestratorType = null)
        {
            WithArguments("--orchestrator-type");
            if (!string.IsNullOrEmpty(orchestratorType))
            {
                 WithArguments(orchestratorType);
            }

            return this;
        }

        /// <summary>
        /// Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Use Orchestrator Version to specify the semantic version for your choice of orchestrator.
        /// </summary>
        public AzureAcsCreateTask OrchestratorVersion(string orchestratorVersion = null)
        {
            WithArguments("--orchestrator-version");
            if (!string.IsNullOrEmpty(orchestratorVersion))
            {
                 WithArguments(orchestratorVersion);
            }

            return this;
        }

        public AzureAcsCreateTask ServicePrincipal(string servicePrincipal = null)
        {
            WithArguments("--service-principal");
            if (!string.IsNullOrEmpty(servicePrincipal))
            {
                 WithArguments(servicePrincipal);
            }

            return this;
        }

        /// <summary>
        /// Configure all linux machines with the SSH RSA public key string.  Your key should include three parts, for example 'ssh-rsa AAAAB...snip...UcyupgH azureuser@linuxvm.
        /// </summary>
        public AzureAcsCreateTask SshKeyValue(string sshKeyValue = null)
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
        public AzureAcsCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Generate and validate the ARM template without creating any resources.
        /// </summary>
        public AzureAcsCreateTask Validate(string validate = null)
        {
            WithArguments("--validate");
            if (!string.IsNullOrEmpty(validate))
            {
                 WithArguments(validate);
            }

            return this;
        }

        /// <summary>
        /// If true, set the default osType of agent pools to be Windows.
        /// </summary>
        public AzureAcsCreateTask Windows(string windows = null)
        {
            WithArguments("--windows");
            if (!string.IsNullOrEmpty(windows))
            {
                 WithArguments(windows);
            }

            return this;
        }
     }
}
