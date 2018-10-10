
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Vm
{
     public partial class AzureVmCreateTask : ExternalProcessTaskBase<AzureVmCreateTask>
     {
        
        /// <summary>
        /// Create an Azure Virtual Machine.
        /// </summary>
        public AzureVmCreateTask(string name = null ,  string resourceGroup = null)
        {
            WithArguments("az vm create");
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
        /// Attach existing data disks to the VM. Can use the name or ID of a managed disk or the URI to an unmanaged disk VHD.
        /// </summary>
        public AzureVmCreateTask AttachDataDisks(string attachDataDisks = null)
        {
            WithArguments("--attach-data-disks");
            if (!string.IsNullOrEmpty(attachDataDisks))
            {
                 WithArguments(attachDataDisks);
            }

            return this;
        }

        /// <summary>
        /// Attach an existing OS disk to the VM. Can use the name or ID of a managed disk or the URI to an unmanaged disk VHD.
        /// </summary>
        public AzureVmCreateTask AttachOsDisk(string attachOsDisk = null)
        {
            WithArguments("--attach-os-disk");
            if (!string.IsNullOrEmpty(attachOsDisk))
            {
                 WithArguments(attachOsDisk);
            }

            return this;
        }

        /// <summary>
        /// Name or ID of an existing availability set to add the VM to. None by default.
        /// </summary>
        public AzureVmCreateTask AvailabilitySet(string availabilitySet = null)
        {
            WithArguments("--availability-set");
            if (!string.IsNullOrEmpty(availabilitySet))
            {
                 WithArguments(availabilitySet);
            }

            return this;
        }

        /// <summary>
        /// Pre-existing storage account name or its blob uri to capture boot diagnostics. Its sku should be one of Standard_GRS, Standard_LRS and Standard_RAGRS.
        /// </summary>
        public AzureVmCreateTask BootDiagnosticsStorage(string bootDiagnosticsStorage = null)
        {
            WithArguments("--boot-diagnostics-storage");
            if (!string.IsNullOrEmpty(bootDiagnosticsStorage))
            {
                 WithArguments(bootDiagnosticsStorage);
            }

            return this;
        }

        /// <summary>
        /// Custom init script file or text (cloud-init, cloud-config, etc..).
        /// </summary>
        public AzureVmCreateTask CustomData(string customData = null)
        {
            WithArguments("--custom-data");
            if (!string.IsNullOrEmpty(customData))
            {
                 WithArguments(customData);
            }

            return this;
        }

        /// <summary>
        /// The name of the operating system image as a URN alias, URN, custom image name or ID, or VHD blob URI. This parameter is required unless using `--attach-os-disk.`.
        /// </summary>
        public AzureVmCreateTask Image(string image = null)
        {
            WithArguments("--image");
            if (!string.IsNullOrEmpty(image))
            {
                 WithArguments(image);
            }

            return this;
        }

        /// <summary>
        /// License type if the Windows image or disk used was licensed on-premises.
        /// </summary>
        public AzureVmCreateTask LicenseType(string licenseType = null)
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
        public AzureVmCreateTask Location(string location = null)
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
        public AzureVmCreateTask NoWait(string noWait = null)
        {
            WithArguments("--no-wait");
            if (!string.IsNullOrEmpty(noWait))
            {
                 WithArguments(noWait);
            }

            return this;
        }

        /// <summary>
        /// One or many Key Vault secrets as JSON strings or files via `@{path}` containing `[{ "sourceVault": { "id": "value" }, "vaultCertificates": [{ "certificateUrl": "value", "certificateStore": "cert store name (only on windows)"}] }]`.
        /// </summary>
        public AzureVmCreateTask Secrets(string secrets = null)
        {
            WithArguments("--secrets");
            if (!string.IsNullOrEmpty(secrets))
            {
                 WithArguments(secrets);
            }

            return this;
        }

        /// <summary>
        /// The VM size to be created. See <a href="https://azure.microsoft.com/en-us/pricing/details/virtual-machines/">https://azure.microsoft.com/en-us/pricing/details/virtual-machines/</a> for size info.
        /// </summary>
        public AzureVmCreateTask Size(string size = null)
        {
            WithArguments("--size");
            if (!string.IsNullOrEmpty(size))
            {
                 WithArguments(size);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public AzureVmCreateTask Tags(string tags = null)
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
        public AzureVmCreateTask Validate(string validate = null)
        {
            WithArguments("--validate");
            if (!string.IsNullOrEmpty(validate))
            {
                 WithArguments(validate);
            }

            return this;
        }

        /// <summary>
        /// Availability zone into which to provision the resource.
        /// </summary>
        public AzureVmCreateTask Zone(string zone = null)
        {
            WithArguments("--zone");
            if (!string.IsNullOrEmpty(zone))
            {
                 WithArguments(zone);
            }

            return this;
        }

        /// <summary>
        /// Password for the VM if authentication type is 'Password'.
        /// </summary>
        public AzureVmCreateTask AdminPassword(string adminPassword = null)
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
        public AzureVmCreateTask AdminUsername(string adminUsername = null)
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
        public AzureVmCreateTask AuthenticationType(string authenticationType = null)
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
        public AzureVmCreateTask GenerateSshKeys(string generateSshKeys = null)
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
        public AzureVmCreateTask SshDestKeyPath(string sshDestKeyPath = null)
        {
            WithArguments("--ssh-dest-key-path");
            if (!string.IsNullOrEmpty(sshDestKeyPath))
            {
                 WithArguments(sshDestKeyPath);
            }

            return this;
        }

        /// <summary>
        /// The SSH public key or public key file path.
        /// </summary>
        public AzureVmCreateTask SshKeyValue(string sshKeyValue = null)
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
        public AzureVmCreateTask AssignIdentity(string assignIdentity = null)
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
        public AzureVmCreateTask Role(string role = null)
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
        public AzureVmCreateTask Scope(string scope = null)
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
        public AzureVmCreateTask PlanName(string planName = null)
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
        public AzureVmCreateTask PlanProduct(string planProduct = null)
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
        public AzureVmCreateTask PlanPromotionCode(string planPromotionCode = null)
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
        public AzureVmCreateTask PlanPublisher(string planPublisher = null)
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
        public AzureVmCreateTask AcceleratedNetworking(string acceleratedNetworking = null)
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
        public AzureVmCreateTask Asgs(string asgs = null)
        {
            WithArguments("--asgs");
            if (!string.IsNullOrEmpty(asgs))
            {
                 WithArguments(asgs);
            }

            return this;
        }

        /// <summary>
        /// Names or IDs of existing NICs to attach to the VM. The first NIC will be designated as primary. If omitted, a new NIC will be created. If an existing NIC is specified, do not specify subnet, VNet, public IP or NSG.
        /// </summary>
        public AzureVmCreateTask Nics(string nics = null)
        {
            WithArguments("--nics");
            if (!string.IsNullOrEmpty(nics))
            {
                 WithArguments(nics);
            }

            return this;
        }

        /// <summary>
        /// The name to use when creating a new Network Security Group (default) or referencing an existing one. Can also reference an existing NSG by ID or specify "" for none.
        /// </summary>
        public AzureVmCreateTask Nsg(string nsg = null)
        {
            WithArguments("--nsg");
            if (!string.IsNullOrEmpty(nsg))
            {
                 WithArguments(nsg);
            }

            return this;
        }

        /// <summary>
        /// NSG rule to create when creating a new NSG. Defaults to open ports for allowing RDP on Windows and allowing SSH on Linux.
        /// </summary>
        public AzureVmCreateTask NsgRule(string nsgRule = null)
        {
            WithArguments("--nsg-rule");
            if (!string.IsNullOrEmpty(nsgRule))
            {
                 WithArguments(nsgRule);
            }

            return this;
        }

        /// <summary>
        /// Static private IP address (e.g. 10.0.0.5).
        /// </summary>
        public AzureVmCreateTask PrivateIpAddress(string privateIpAddress = null)
        {
            WithArguments("--private-ip-address");
            if (!string.IsNullOrEmpty(privateIpAddress))
            {
                 WithArguments(privateIpAddress);
            }

            return this;
        }

        /// <summary>
        /// Name of the public IP address when creating one (default) or referencing an existing one. Can also reference an existing public IP by ID or specify "" for None.
        /// </summary>
        public AzureVmCreateTask PublicIpAddress(string publicIpAddress = null)
        {
            WithArguments("--public-ip-address");
            if (!string.IsNullOrEmpty(publicIpAddress))
            {
                 WithArguments(publicIpAddress);
            }

            return this;
        }

        public AzureVmCreateTask PublicIpAddressAllocation(string publicIpAddressAllocation = null)
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
        public AzureVmCreateTask PublicIpAddressDnsName(string publicIpAddressDnsName = null)
        {
            WithArguments("--public-ip-address-dns-name");
            if (!string.IsNullOrEmpty(publicIpAddressDnsName))
            {
                 WithArguments(publicIpAddressDnsName);
            }

            return this;
        }

        /// <summary>
        /// Sku.
        /// </summary>
        public AzureVmCreateTask PublicIpSku(string publicIpSku = null)
        {
            WithArguments("--public-ip-sku");
            if (!string.IsNullOrEmpty(publicIpSku))
            {
                 WithArguments(publicIpSku);
            }

            return this;
        }

        /// <summary>
        /// The name of the subnet when creating a new VNet or referencing an existing one. Can also reference an existing subnet by ID. If omitted, an appropriate VNet and subnet will be selected automatically, or a new one will be created.
        /// </summary>
        public AzureVmCreateTask Subnet(string subnet = null)
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
        public AzureVmCreateTask SubnetAddressPrefix(string subnetAddressPrefix = null)
        {
            WithArguments("--subnet-address-prefix");
            if (!string.IsNullOrEmpty(subnetAddressPrefix))
            {
                 WithArguments(subnetAddressPrefix);
            }

            return this;
        }

        /// <summary>
        /// The IP address prefix to use when creating a new VNet in CIDR format.
        /// </summary>
        public AzureVmCreateTask VnetAddressPrefix(string vnetAddressPrefix = null)
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
        public AzureVmCreateTask VnetName(string vnetName = null)
        {
            WithArguments("--vnet-name");
            if (!string.IsNullOrEmpty(vnetName))
            {
                 WithArguments(vnetName);
            }

            return this;
        }

        /// <summary>
        /// Storage caching type for data disk(s), including 'None', 'ReadOnly', 'ReadWrite', etc. Use a singular value to apply on all disks, or use '<lun>=<vaule1> <lun>=<value2>' to configure individual disk.
        /// </summary>
        public AzureVmCreateTask DataDiskCaching(string dataDiskCaching = null)
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
        public AzureVmCreateTask DataDiskSizesGb(string dataDiskSizesGb = null)
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
        public AzureVmCreateTask OsDiskCaching(string osDiskCaching = null)
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
        public AzureVmCreateTask OsDiskName(string osDiskName = null)
        {
            WithArguments("--os-disk-name");
            if (!string.IsNullOrEmpty(osDiskName))
            {
                 WithArguments(osDiskName);
            }

            return this;
        }

        /// <summary>
        /// The size of the os disk in GB.
        /// </summary>
        public AzureVmCreateTask OsDiskSizeGb(string osDiskSizeGb = null)
        {
            WithArguments("--os-disk-size-gb");
            if (!string.IsNullOrEmpty(osDiskSizeGb))
            {
                 WithArguments(osDiskSizeGb);
            }

            return this;
        }

        /// <summary>
        /// Type of OS installed on a custom VHD. Do not use when specifying an URN or URN alias.
        /// </summary>
        public AzureVmCreateTask OsType(string osType = null)
        {
            WithArguments("--os-type");
            if (!string.IsNullOrEmpty(osType))
            {
                 WithArguments(osType);
            }

            return this;
        }

        /// <summary>
        /// Only applicable when used with `--use-unmanaged-disk`. The name to use when creating a new storage account or referencing an existing one. If omitted, an appropriate storage account in the same resource group and location will be used, or a new one will be created.
        /// </summary>
        public AzureVmCreateTask StorageAccount(string storageAccount = null)
        {
            WithArguments("--storage-account");
            if (!string.IsNullOrEmpty(storageAccount))
            {
                 WithArguments(storageAccount);
            }

            return this;
        }

        /// <summary>
        /// Only applicable when used with `--use-unmanaged-disk`. Name of the storage container for the VM OS disk. Default: vhds.
        /// </summary>
        public AzureVmCreateTask StorageContainerName(string storageContainerName = null)
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
        public AzureVmCreateTask StorageSku(string storageSku = null)
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
        public AzureVmCreateTask UltraSsdEnabled(string ultraSsdEnabled = null)
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
        public AzureVmCreateTask UseUnmanagedDisk(string useUnmanagedDisk = null)
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
