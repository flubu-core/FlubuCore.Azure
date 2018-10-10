
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Lab
{
     public partial class AzureLabVmCreateTask : ExternalProcessTaskBase<AzureLabVmCreateTask>
     {
        
        /// <summary>
        /// Create a VM in a lab.
        /// </summary>
        public AzureLabVmCreateTask(string labName = null ,  string name = null ,  string resourceGroup = null)
        {
            WithArguments("az lab vm create");
WithArguments("--lab-name");
            if (!string.IsNullOrEmpty(labName))
            {
                 WithArguments(labName);
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
        /// Flag indicating if the VM should be created as claimable.
        /// </summary>
        public AzureLabVmCreateTask AllowClaim(string allowClaim = null)
        {
            WithArguments("--allow-claim");
            if (!string.IsNullOrEmpty(allowClaim))
            {
                 WithArguments(allowClaim);
            }

            return this;
        }

        /// <summary>
        /// JSON encoded array of artifacts to be applied. Use '@{file}' to load from a file.
        /// </summary>
        public AzureLabVmCreateTask Artifacts(string artifacts = null)
        {
            WithArguments("--artifacts");
            if (!string.IsNullOrEmpty(artifacts))
            {
                 WithArguments(artifacts);
            }

            return this;
        }

        /// <summary>
        /// Storage type to use for virtual machine.
        /// </summary>
        public AzureLabVmCreateTask DiskType(string diskType = null)
        {
            WithArguments("--disk-type");
            if (!string.IsNullOrEmpty(diskType))
            {
                 WithArguments(diskType);
            }

            return this;
        }

        /// <summary>
        /// The expiration date in UTC(YYYY-mm-dd) for the VM.
        /// </summary>
        public AzureLabVmCreateTask ExpirationDate(string expirationDate = null)
        {
            WithArguments("--expiration-date");
            if (!string.IsNullOrEmpty(expirationDate))
            {
                 WithArguments(expirationDate);
            }

            return this;
        }

        /// <summary>
        /// Name of the formula. Use `az lab formula list` for available formulas.
        /// </summary>
        public AzureLabVmCreateTask Formula(string formula = null)
        {
            WithArguments("--formula");
            if (!string.IsNullOrEmpty(formula))
            {
                 WithArguments(formula);
            }

            return this;
        }

        /// <summary>
        /// Generate SSH public and private key files if missing.
        /// </summary>
        public AzureLabVmCreateTask GenerateSshKeys(string generateSshKeys = null)
        {
            WithArguments("--generate-ssh-keys");
            if (!string.IsNullOrEmpty(generateSshKeys))
            {
                 WithArguments(generateSshKeys);
            }

            return this;
        }

        /// <summary>
        /// The name of the operating system image (gallery image name or custom image name/ID).
        /// </summary>
        public AzureLabVmCreateTask Image(string image = null)
        {
            WithArguments("--image");
            if (!string.IsNullOrEmpty(image))
            {
                 WithArguments(image);
            }

            return this;
        }

        /// <summary>
        /// Type of the image. Allowed values are: gallery, custom.
        /// </summary>
        public AzureLabVmCreateTask ImageType(string imageType = null)
        {
            WithArguments("--image-type");
            if (!string.IsNullOrEmpty(imageType))
            {
                 WithArguments(imageType);
            }

            return this;
        }

        /// <summary>
        /// Notes for the virtual machine.
        /// </summary>
        public AzureLabVmCreateTask Notes(string notes = null)
        {
            WithArguments("--notes");
            if (!string.IsNullOrEmpty(notes))
            {
                 WithArguments(notes);
            }

            return this;
        }

        /// <summary>
        /// The size of the VM to be created. See <a href="https://azure.microsoft.com/en-us/pricing/details/virtual-machines/">https://azure.microsoft.com/en-us/pricing/details/virtual-machines/</a> for size info.
        /// </summary>
        public AzureLabVmCreateTask Size(string size = null)
        {
            WithArguments("--size");
            if (!string.IsNullOrEmpty(size))
            {
                 WithArguments(size);
            }

            return this;
        }

        /// <summary>
        /// Space-separated tags in `key[=value]` format.
        /// </summary>
        public AzureLabVmCreateTask Tags(string tags = null)
        {
            WithArguments("--tags");
            if (!string.IsNullOrEmpty(tags))
            {
                 WithArguments(tags);
            }

            return this;
        }

        /// <summary>
        /// Password for the VM admin.
        /// </summary>
        public AzureLabVmCreateTask AdminPassword(string adminPassword = null)
        {
            WithArguments("--admin-password");
            if (!string.IsNullOrEmpty(adminPassword))
            {
                 WithArguments(adminPassword);
            }

            return this;
        }

        /// <summary>
        /// Username for the VM admin.
        /// </summary>
        public AzureLabVmCreateTask AdminUsername(string adminUsername = null)
        {
            WithArguments("--admin-username");
            if (!string.IsNullOrEmpty(adminUsername))
            {
                 WithArguments(adminUsername);
            }

            return this;
        }

        /// <summary>
        /// Type of authentication allowed for the VM. Allowed values are: password, ssh.
        /// </summary>
        public AzureLabVmCreateTask AuthenticationType(string authenticationType = null)
        {
            WithArguments("--authentication-type");
            if (!string.IsNullOrEmpty(authenticationType))
            {
                 WithArguments(authenticationType);
            }

            return this;
        }

        /// <summary>
        /// Name of the saved secret to be used for authentication.
        /// </summary>
        public AzureLabVmCreateTask SavedSecret(string savedSecret = null)
        {
            WithArguments("--saved-secret");
            if (!string.IsNullOrEmpty(savedSecret))
            {
                 WithArguments(savedSecret);
            }

            return this;
        }

        /// <summary>
        /// The SSH public key or public key file path. Use `--generate-ssh-keys` to generate SSH keys.
        /// </summary>
        public AzureLabVmCreateTask SshKey(string sshKey = null)
        {
            WithArguments("--ssh-key");
            if (!string.IsNullOrEmpty(sshKey))
            {
                 WithArguments(sshKey);
            }

            return this;
        }

        /// <summary>
        /// Type of IP configuration to use for the VM. Allowed values are: shared, public, private.
        /// </summary>
        public AzureLabVmCreateTask IpConfiguration(string ipConfiguration = null)
        {
            WithArguments("--ip-configuration");
            if (!string.IsNullOrEmpty(ipConfiguration))
            {
                 WithArguments(ipConfiguration);
            }

            return this;
        }

        /// <summary>
        /// Name of the subnet to add the VM to.
        /// </summary>
        public AzureLabVmCreateTask Subnet(string subnet = null)
        {
            WithArguments("--subnet");
            if (!string.IsNullOrEmpty(subnet))
            {
                 WithArguments(subnet);
            }

            return this;
        }

        /// <summary>
        /// Name of the virtual network to add the VM to.
        /// </summary>
        public AzureLabVmCreateTask VnetName(string vnetName = null)
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
