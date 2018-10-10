
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vmss
{
     public partial class AzureVmssCreateTask : ExternalProcessTaskBase<AzureVmssCreateTask>
     {
        
        /// <summary>
        /// Create an Azure Virtual Machine Scale Set.
        /// </summary>
        public AzureVmssCreateTask(string image = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vmss create");
WithArguments("--image");
            if (!string.IsNullOrEmpty(image))
            {
                 WithArguments(image);
            }

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
        /// Custom init script file or text (cloud-init, cloud-config, etc..).
        /// </summary>
        public AzureVmssCreateTask CustomData(string customData = null)
        {
            WithArguments("--custom-data");
            if (!string.IsNullOrEmpty(customData))
            {
                 WithArguments(customData);
            }

            return this;
        }

        /// <summary>
        /// Overprovision option (see <a href="https://azure.microsoft.com/en-us/documentation/articles/virtual-machine-scale-sets-overview/">https://azure.microsoft.com/en-us/documentation/articles/virtual-machine-scale-sets-overview/</a> for details).
        /// </summary>
        public AzureVmssCreateTask DisableOverprovision(string disableOverprovision = null)
        {
            WithArguments("--disable-overprovision");
            if (!string.IsNullOrEmpty(disableOverprovision))
            {
                 WithArguments(disableOverprovision);
            }

            return this;
        }

        /// <summary>
        /// (PREVIEW) the eviction policy for virtual machines in a low priority scale set.
        /// </summary>
        public AzureVmssCreateTask EvictionPolicy(string evictionPolicy = null)
        {
            WithArguments("--eviction-policy");
            if (!string.IsNullOrEmpty(evictionPolicy))
            {
                 WithArguments(evictionPolicy);
            }

            return this;
        }

        /// <summary>
        /// (Preview) probe name from the existing load balancer, mainly used for rolling upgrade.
        /// </summary>
        public AzureVmssCreateTask HealthProbe(string healthProbe = null)
        {
            WithArguments("--health-probe");
            if (!string.IsNullOrEmpty(healthProbe))
            {
                 WithArguments(healthProbe);
            }

            return this;
        }

        /// <summary>
        /// Number of VMs in the scale set.
        /// </summary>
        public AzureVmssCreateTask InstanceCount(string instanceCount = null)
        {
            WithArguments("--instance-count");
            if (!string.IsNullOrEmpty(instanceCount))
            {
                 WithArguments(instanceCount);
            }

            return this;
        }

        /// <summary>
        /// License type if the Windows image or disk used was licensed on-premises.
        /// </summary>
        public AzureVmssCreateTask LicenseType(string licenseType = null)
        {
            WithArguments("--license-type");
            if (!string.IsNullOrEmpty(licenseType))
            {
                 WithArguments(licenseType);
            }

            return this;
        }

        /// <summary>
        /// Location in which to create VM and related resources. If default location is not configured, will default to the resource group's location.
        /// </summary>
        public AzureVmssCreateTask Location(string location = null)
        {
            WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

            return this;
        }

        /// <summary>
        /// Do not wait for the long-running operation to finish.
        /// </summary>
        public AzureVmssCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// Fault Domain count for each placement group in the availability zone.
        /// </summary>
        public AzureVmssCreateTask PlatformFaultDomainCount(string platformFaultDomainCount = null)
        {
            WithArguments("--platform-fault-domain-count");
            if (!string.IsNullOrEmpty(platformFaultDomainCount))
            {
                 WithArguments(platformFaultDomainCount);
            }

            return this;
        }

        /// <summary>
        /// (PREVIEW)Priority. Use 'Low' to run short-lived workloads in a cost-effective way.
        /// </summary>
        public AzureVmssCreateTask Priority(string priority = null)
        {
            WithArguments("--priority");
            if (!string.IsNullOrEmpty(priority))
            {
                 WithArguments(priority);
            }

            return this;
        }

        /// <summary>
        /// One or many Key Vault secrets as JSON strings or files via `@{path}` containing `[{ "sourceVault": { "id": "value" }, "vaultCertificates": [{ "certificateUrl": "value", "certificateStore": "cert store name (only on windows)"}] }]`.
        /// </summary>
        public AzureVmssCreateTask Secrets(string secrets = null)
        {
            WithArguments("--secrets");
            if (!string.IsNullOrEmpty(secrets))
            {
                 WithArguments(secrets);
            }

            return this;
        }

        /// <summary>
        /// Enable replicate using fault domains within the same cluster. Default to 'false' for any zonals, or with 100+ instances See <a href="https://docs.microsoft.com/en-us/azure/virtual-machine-scale-sets/virtual-machine-scale-sets-placement-groups">https://docs.microsoft.com/en-us/azure/virtual-machine-scale-sets/virtual-machine-scale-sets-placement-groups</a> for details.
        /// </summary>
        public AzureVmssCreateTask SinglePlacementGroup(string singlePlacementGroup = null)
        {
            WithArguments("--single-placement-group");
            if (!string.IsNullOrEmpty(singlePlacementGroup))
            {
                 WithArguments(singlePlacementGroup);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureVmssCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        public AzureVmssCreateTask UpgradePolicyMode(string upgradePolicyMode = null)
        {
            WithArguments("--upgrade-policy-mode");
            if (!string.IsNullOrEmpty(upgradePolicyMode))
            {
                 WithArguments(upgradePolicyMode);
            }

            return this;
        }

        /// <summary>
        /// Generate and validate the ARM template without creating any resources.
        /// </summary>
        public AzureVmssCreateTask Validate(string validate = null)
        {
            WithArguments("--validate");
            if (!string.IsNullOrEmpty(validate))
            {
                 WithArguments(validate);
            }

            return this;
        }

        /// <summary>
        /// Size of VMs in the scale set. Default to "Standard_DS1_v2". See <a href="https://azure.microsoft.com/en-us/pricing/details/virtual-machines/">https://azure.microsoft.com/en-us/pricing/details/virtual-machines/</a> for size info.
        /// </summary>
        public AzureVmssCreateTask VmSku(string vmSku = null)
        {
            WithArguments("--vm-sku");
            if (!string.IsNullOrEmpty(vmSku))
            {
                 WithArguments(vmSku);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of availability zones into which to provision the resource.
        /// </summary>
        public AzureVmssCreateTask Zones(string zones = null)
        {
            WithArguments("--zones");
            if (!string.IsNullOrEmpty(zones))
            {
                 WithArguments(zones);
            }

            return this;
        }

        /// <summary>
        /// Password for the VM if authentication type is 'Password'.
        /// </summary>
        public AzureVmssCreateTask AdminPassword(string adminPassword = null)
        {
            WithArguments("--admin-password");
            if (!string.IsNullOrEmpty(adminPassword))
            {
                 WithArguments(adminPassword);
            }

            return this;
        }

        /// <summary>
        /// Username for the VM.
        /// </summary>
        public AzureVmssCreateTask AdminUsername(string adminUsername = null)
        {
            WithArguments("--admin-username");
            if (!string.IsNullOrEmpty(adminUsername))
            {
                 WithArguments(adminUsername);
            }

            return this;
        }

        /// <summary>
        /// Type of authentication to use with the VM. Defaults to password for Windows and SSH public key for Linux.
        /// </summary>
        public AzureVmssCreateTask AuthenticationType(string authenticationType = null)
        {
            WithArguments("--authentication-type");
            if (!string.IsNullOrEmpty(authenticationType))
            {
                 WithArguments(authenticationType);
            }

            return this;
        }

        /// <summary>
        /// Generate SSH public and private key files if missing. The keys will be stored in the ~/.ssh directory.
        /// </summary>
        public AzureVmssCreateTask GenerateSshKeys(string generateSshKeys = null)
        {
            WithArguments("--generate-ssh-keys");
            if (!string.IsNullOrEmpty(generateSshKeys))
            {
                 WithArguments(generateSshKeys);
            }

            return this;
        }

        /// <summary>
        /// Destination file path on the VM for the SSH key.
        /// </summary>
        public AzureVmssCreateTask SshDestKeyPath(string sshDestKeyPath = null)
        {
            WithArguments("--ssh-dest-key-path");
            if (!string.IsNullOrEmpty(sshDestKeyPath))
            {
                 WithArguments(sshDestKeyPath);
            }

            return this;
        }

        /// <summary>
        /// SSH public key or public key file path.
        /// </summary>
        public AzureVmssCreateTask SshKeyValue(string sshKeyValue = null)
        {
            WithArguments("--ssh-key-value");
            if (!string.IsNullOrEmpty(sshKeyValue))
            {
                 WithArguments(sshKeyValue);
            }

            return this;
        }

        /// <summary>
        /// Accept system or user assigned identities separated by spaces. Use '[system]' to refer system assigned identity, or a resource id to refer user assigned identity. Check out help for more examples.
        /// </summary>
        public AzureVmssCreateTask AssignIdentity(string assignIdentity = null)
        {
            WithArguments("--assign-identity");
            if (!string.IsNullOrEmpty(assignIdentity))
            {
                 WithArguments(assignIdentity);
            }

            return this;
        }

        /// <summary>
        /// Role name or id the system assigned identity will have.
        /// </summary>
        public AzureVmssCreateTask Role(string role = null)
        {
            WithArguments("--role");
            if (!string.IsNullOrEmpty(role))
            {
                 WithArguments(role);
            }

            return this;
        }

        /// <summary>
        /// Scope that the system assigned identity can access.
        /// </summary>
        public AzureVmssCreateTask Scope(string scope = null)
        {
            WithArguments("--scope");
            if (!string.IsNullOrEmpty(scope))
            {
                 WithArguments(scope);
            }

            return this;
        }

        /// <summary>
        /// Plan name.
        /// </summary>
        public AzureVmssCreateTask PlanName(string planName = null)
        {
            WithArguments("--plan-name");
            if (!string.IsNullOrEmpty(planName))
            {
                 WithArguments(planName);
            }

            return this;
        }

        /// <summary>
        /// Plan product.
        /// </summary>
        public AzureVmssCreateTask PlanProduct(string planProduct = null)
        {
            WithArguments("--plan-product");
            if (!string.IsNullOrEmpty(planProduct))
            {
                 WithArguments(planProduct);
            }

            return this;
        }

        /// <summary>
        /// Plan promotion code.
        /// </summary>
        public AzureVmssCreateTask PlanPromotionCode(string planPromotionCode = null)
        {
            WithArguments("--plan-promotion-code");
            if (!string.IsNullOrEmpty(planPromotionCode))
            {
                 WithArguments(planPromotionCode);
            }

            return this;
        }

        /// <summary>
        /// Plan publisher.
        /// </summary>
        public AzureVmssCreateTask PlanPublisher(string planPublisher = null)
        {
            WithArguments("--plan-publisher");
            if (!string.IsNullOrEmpty(planPublisher))
            {
                 WithArguments(planPublisher);
            }

            return this;
        }

        /// <summary>
        /// Enable accelerated networking. Unless specified, CLI will enable it based on machine image and size.
        /// </summary>
        public AzureVmssCreateTask AcceleratedNetworking(string acceleratedNetworking = null)
        {
            WithArguments("--accelerated-networking");
            if (!string.IsNullOrEmpty(acceleratedNetworking))
            {
                 WithArguments(acceleratedNetworking);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of existing application security groups to associate with the VM.
        /// </summary>
        public AzureVmssCreateTask Asgs(string asgs = null)
        {
            WithArguments("--asgs");
            if (!string.IsNullOrEmpty(asgs))
            {
                 WithArguments(asgs);
            }

            return this;
        }

        /// <summary>
        /// Space-separated IP addresses of DNS servers, e.g. 10.0.0.5 10.0.0.6.
        /// </summary>
        public AzureVmssCreateTask DnsServers(string dnsServers = null)
        {
            WithArguments("--dns-servers");
            if (!string.IsNullOrEmpty(dnsServers))
            {
                 WithArguments(dnsServers);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of an existing Network Security Group.
        /// </summary>
        public AzureVmssCreateTask Nsg(string nsg = null)
        {
            WithArguments("--nsg");
            if (!string.IsNullOrEmpty(nsg))
            {
                 WithArguments(nsg);
            }

            return this;
        }

        /// <summary>
        /// Name of the public IP address when creating one (default) or referencing an existing one. Can also reference an existing public IP by ID or specify "" for None.
        /// </summary>
        public AzureVmssCreateTask PublicIpAddress(string publicIpAddress = null)
        {
            WithArguments("--public-ip-address");
            if (!string.IsNullOrEmpty(publicIpAddress))
            {
                 WithArguments(publicIpAddress);
            }

            return this;
        }

        public AzureVmssCreateTask PublicIpAddressAllocation(string publicIpAddressAllocation = null)
        {
            WithArguments("--public-ip-address-allocation");
            if (!string.IsNullOrEmpty(publicIpAddressAllocation))
            {
                 WithArguments(publicIpAddressAllocation);
            }

            return this;
        }

        /// <summary>
        /// Globally unique DNS name for a newly created public IP.
        /// </summary>
        public AzureVmssCreateTask PublicIpAddressDnsName(string publicIpAddressDnsName = null)
        {
            WithArguments("--public-ip-address-dns-name");
            if (!string.IsNullOrEmpty(publicIpAddressDnsName))
            {
                 WithArguments(publicIpAddressDnsName);
            }

            return this;
        }

        /// <summary>
        /// Each VM instance will have a public ip. For security, you can use '--nsg' to apply appropriate rules.
        /// </summary>
        public AzureVmssCreateTask PublicIpPerVm(string publicIpPerVm = null)
        {
            WithArguments("--public-ip-per-vm");
            if (!string.IsNullOrEmpty(publicIpPerVm))
            {
                 WithArguments(publicIpPerVm);
            }

            return this;
        }

        /// <summary>
        /// The name of the subnet when creating a new VNet or referencing an existing one. Can also reference an existing subnet by ID. If omitted, an appropriate VNet and subnet will be selected automatically, or a new one will be created.
        /// </summary>
        public AzureVmssCreateTask Subnet(string subnet = null)
        {
            WithArguments("--subnet");
            if (!string.IsNullOrEmpty(subnet))
            {
                 WithArguments(subnet);
            }

            return this;
        }

        /// <summary>
        /// The subnet IP address prefix to use when creating a new VNet in CIDR format.
        /// </summary>
        public AzureVmssCreateTask SubnetAddressPrefix(string subnetAddressPrefix = null)
        {
            WithArguments("--subnet-address-prefix");
            if (!string.IsNullOrEmpty(subnetAddressPrefix))
            {
                 WithArguments(subnetAddressPrefix);
            }

            return this;
        }

        /// <summary>
        /// Domain name of VM instances, once configured, the FQDN is 'vm<vm-index>.<vm-domain-name>.<..rest..>'.
        /// </summary>
        public AzureVmssCreateTask VmDomainName(string vmDomainName = null)
        {
            WithArguments("--vm-domain-name");
            if (!string.IsNullOrEmpty(vmDomainName))
            {
                 WithArguments(vmDomainName);
            }

            return this;
        }

        /// <summary>
        /// The IP address prefix to use when creating a new VNet in CIDR format.
        /// </summary>
        public AzureVmssCreateTask VnetAddressPrefix(string vnetAddressPrefix = null)
        {
            WithArguments("--vnet-address-prefix");
            if (!string.IsNullOrEmpty(vnetAddressPrefix))
            {
                 WithArguments(vnetAddressPrefix);
            }

            return this;
        }

        /// <summary>
        /// Name of the virtual network when creating a new one or referencing an existing one.
        /// </summary>
        public AzureVmssCreateTask VnetName(string vnetName = null)
        {
            WithArguments("--vnet-name");
            if (!string.IsNullOrEmpty(vnetName))
            {
                 WithArguments(vnetName);
            }

            return this;
        }

        /// <summary>
        /// Name to use when creating a new application gateway (default) or referencing an existing one. Can also reference an existing application gateway by ID or specify "" for none.
        /// </summary>
        public AzureVmssCreateTask AppGateway(string appGateway = null)
        {
            WithArguments("--app-gateway");
            if (!string.IsNullOrEmpty(appGateway))
            {
                 WithArguments(appGateway);
            }

            return this;
        }

        /// <summary>
        /// The number of instances to use when creating a new application gateway.
        /// </summary>
        public AzureVmssCreateTask AppGatewayCapacity(string appGatewayCapacity = null)
        {
            WithArguments("--app-gateway-capacity");
            if (!string.IsNullOrEmpty(appGatewayCapacity))
            {
                 WithArguments(appGatewayCapacity);
            }

            return this;
        }

        /// <summary>
        /// SKU when creating a new application gateway.
        /// </summary>
        public AzureVmssCreateTask AppGatewaySku(string appGatewaySku = null)
        {
            WithArguments("--app-gateway-sku");
            if (!string.IsNullOrEmpty(appGatewaySku))
            {
                 WithArguments(appGatewaySku);
            }

            return this;
        }

        /// <summary>
        /// The subnet IP address prefix to use when creating a new application gateway in CIDR format.
        /// </summary>
        public AzureVmssCreateTask AppGatewaySubnetAddressPrefix(string appGatewaySubnetAddressPrefix = null)
        {
            WithArguments("--app-gateway-subnet-address-prefix");
            if (!string.IsNullOrEmpty(appGatewaySubnetAddressPrefix))
            {
                 WithArguments(appGatewaySubnetAddressPrefix);
            }

            return this;
        }

        /// <summary>
        /// Name to use for the backend pool when creating a new load balancer or application gateway.
        /// </summary>
        public AzureVmssCreateTask BackendPoolName(string backendPoolName = null)
        {
            WithArguments("--backend-pool-name");
            if (!string.IsNullOrEmpty(backendPoolName))
            {
                 WithArguments(backendPoolName);
            }

            return this;
        }

        /// <summary>
        /// When creating a new load balancer, backend port to open with NAT rules (Defaults to 22 on Linux and 3389 on Windows). When creating an application gateway, the backend port to use for the backend HTTP settings.
        /// </summary>
        public AzureVmssCreateTask BackendPort(string backendPort = null)
        {
            WithArguments("--backend-port");
            if (!string.IsNullOrEmpty(backendPort))
            {
                 WithArguments(backendPort);
            }

            return this;
        }

        /// <summary>
        /// Name to use when creating a new load balancer (default) or referencing an existing one. Can also reference an existing load balancer by ID or specify "" for none.
        /// </summary>
        public AzureVmssCreateTask Lb(string lb = null)
        {
            WithArguments("--lb");
            if (!string.IsNullOrEmpty(lb))
            {
                 WithArguments(lb);
            }

            return this;
        }

        /// <summary>
        /// Name to use for the NAT pool when creating a new load balancer.
        /// </summary>
        public AzureVmssCreateTask LbNatPoolName(string lbNatPoolName = null)
        {
            WithArguments("--lb-nat-pool-name");
            if (!string.IsNullOrEmpty(lbNatPoolName))
            {
                 WithArguments(lbNatPoolName);
            }

            return this;
        }

        /// <summary>
        /// Sku of the Load Balancer to create. Default to 'Standard' when single placement group is turned off; otherwise, default to 'Basic'.
        /// </summary>
        public AzureVmssCreateTask LbSku(string lbSku = null)
        {
            WithArguments("--lb-sku");
            if (!string.IsNullOrEmpty(lbSku))
            {
                 WithArguments(lbSku);
            }

            return this;
        }

        /// <summary>
        /// Storage caching type for data disk(s), including 'None', 'ReadOnly', 'ReadWrite', etc. Use a singular value to apply on all disks, or use '<lun>=<vaule1> <lun>=<value2>' to configure individual disk.
        /// </summary>
        public AzureVmssCreateTask DataDiskCaching(string dataDiskCaching = null)
        {
            WithArguments("--data-disk-caching");
            if (!string.IsNullOrEmpty(dataDiskCaching))
            {
                 WithArguments(dataDiskCaching);
            }

            return this;
        }

        /// <summary>
        /// Space-separated empty managed data disk sizes in GB to create.
        /// </summary>
        public AzureVmssCreateTask DataDiskSizesGb(string dataDiskSizesGb = null)
        {
            WithArguments("--data-disk-sizes-gb");
            if (!string.IsNullOrEmpty(dataDiskSizesGb))
            {
                 WithArguments(dataDiskSizesGb);
            }

            return this;
        }

        /// <summary>
        /// Storage caching type for the VM OS disk. Default: ReadWrite.
        /// </summary>
        public AzureVmssCreateTask OsDiskCaching(string osDiskCaching = null)
        {
            WithArguments("--os-disk-caching");
            if (!string.IsNullOrEmpty(osDiskCaching))
            {
                 WithArguments(osDiskCaching);
            }

            return this;
        }

        /// <summary>
        /// The name of the new VM OS disk.
        /// </summary>
        public AzureVmssCreateTask OsDiskName(string osDiskName = null)
        {
            WithArguments("--os-disk-name");
            if (!string.IsNullOrEmpty(osDiskName))
            {
                 WithArguments(osDiskName);
            }

            return this;
        }

        /// <summary>
        /// Type of OS installed on a custom VHD. Do not use when specifying an URN or URN alias.
        /// </summary>
        public AzureVmssCreateTask OsType(string osType = null)
        {
            WithArguments("--os-type");
            if (!string.IsNullOrEmpty(osType))
            {
                 WithArguments(osType);
            }

            return this;
        }

        /// <summary>
        /// Only applicable when used with `--use-unmanaged-disk`. Name of the storage container for the VM OS disk. Default: vhds.
        /// </summary>
        public AzureVmssCreateTask StorageContainerName(string storageContainerName = null)
        {
            WithArguments("--storage-container-name");
            if (!string.IsNullOrEmpty(storageContainerName))
            {
                 WithArguments(storageContainerName);
            }

            return this;
        }

        /// <summary>
        /// The SKU of the storage account with which to persist VM.
        /// </summary>
        public AzureVmssCreateTask StorageSku(string storageSku = null)
        {
            WithArguments("--storage-sku");
            if (!string.IsNullOrEmpty(storageSku))
            {
                 WithArguments(storageSku);
            }

            return this;
        }

        /// <summary>
        /// (PREVIEW)Enables or disables the capability to have 1 or more managed data disks with UltraSSD_LRS storage account.
        /// </summary>
        public AzureVmssCreateTask UltraSsdEnabled(string ultraSsdEnabled = null)
        {
            WithArguments("--ultra-ssd-enabled");
            if (!string.IsNullOrEmpty(ultraSsdEnabled))
            {
                 WithArguments(ultraSsdEnabled);
            }

            return this;
        }

        /// <summary>
        /// Do not use managed disk to persist VM.
        /// </summary>
        public AzureVmssCreateTask UseUnmanagedDisk(string useUnmanagedDisk = null)
        {
            WithArguments("--use-unmanaged-disk");
            if (!string.IsNullOrEmpty(useUnmanagedDisk))
            {
                 WithArguments(useUnmanagedDisk);
            }

            return this;
        }
     }
}
