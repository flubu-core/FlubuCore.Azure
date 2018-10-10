
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfClusterCreateTask : ExternalProcessTaskBase<AzureSfClusterCreateTask>
     {
        
        /// <summary>
        /// Create a new Azure Service Fabric cluster.
        /// </summary>
        public AzureSfClusterCreateTask(string location = null ,  string resourceGroup = null)
        {
            WithArguments("az sf cluster create");
WithArguments("--location");
            if (!string.IsNullOrEmpty(location))
            {
                 WithArguments(location);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// The existing certificate file path for the primary cluster certificate.
        /// </summary>
        public AzureSfClusterCreateTask CertificateFile(string certificateFile = null)
        {
            WithArguments("--certificate-file");
            if (!string.IsNullOrEmpty(certificateFile))
            {
                 WithArguments(certificateFile);
            }

            return this;
        }

        /// <summary>
        /// The folder of the new certificate file to be created.
        /// </summary>
        public AzureSfClusterCreateTask CertificateOutputFolder(string certificateOutputFolder = null)
        {
            WithArguments("--certificate-output-folder");
            if (!string.IsNullOrEmpty(certificateOutputFolder))
            {
                 WithArguments(certificateOutputFolder);
            }

            return this;
        }

        /// <summary>
        /// The password of the certificate file.
        /// </summary>
        public AzureSfClusterCreateTask CertificatePassword(string certificatePassword = null)
        {
            WithArguments("--certificate-password");
            if (!string.IsNullOrEmpty(certificatePassword))
            {
                 WithArguments(certificatePassword);
            }

            return this;
        }

        /// <summary>
        /// The subject name of the certificate to be created.
        /// </summary>
        public AzureSfClusterCreateTask CertificateSubjectName(string certificateSubjectName = null)
        {
            WithArguments("--certificate-subject-name");
            if (!string.IsNullOrEmpty(certificateSubjectName))
            {
                 WithArguments(certificateSubjectName);
            }

            return this;
        }

        /// <summary>
        /// Specify the name of the cluster, if not given it will be same as resource group name.
        /// </summary>
        public AzureSfClusterCreateTask ClusterName(string clusterName = null)
        {
            WithArguments("--cluster-name");
            if (!string.IsNullOrEmpty(clusterName))
            {
                 WithArguments(clusterName);
            }

            return this;
        }

        /// <summary>
        /// The number of nodes in the cluster. Default are 5 nodes.
        /// </summary>
        public AzureSfClusterCreateTask ClusterSize(string clusterSize = null)
        {
            WithArguments("--cluster-size");
            if (!string.IsNullOrEmpty(clusterSize))
            {
                 WithArguments(clusterSize);
            }

            return this;
        }

        /// <summary>
        /// The Operating System of the VMs that make up the cluster.
        /// </summary>
        public AzureSfClusterCreateTask Os(string os = null)
        {
            WithArguments("--os");
            if (!string.IsNullOrEmpty(os))
            {
                 WithArguments(os);
            }

            return this;
        }

        /// <summary>
        /// The path to the template parameter file.
        /// </summary>
        public AzureSfClusterCreateTask ParameterFile(string parameterFile = null)
        {
            WithArguments("--parameter-file");
            if (!string.IsNullOrEmpty(parameterFile))
            {
                 WithArguments(parameterFile);
            }

            return this;
        }

        /// <summary>
        /// The existing Azure key vault secret URL.
        /// </summary>
        public AzureSfClusterCreateTask SecretIdentifier(string secretIdentifier = null)
        {
            WithArguments("--secret-identifier");
            if (!string.IsNullOrEmpty(secretIdentifier))
            {
                 WithArguments(secretIdentifier);
            }

            return this;
        }

        /// <summary>
        /// The path to the template file.
        /// </summary>
        public AzureSfClusterCreateTask TemplateFile(string templateFile = null)
        {
            WithArguments("--template-file");
            if (!string.IsNullOrEmpty(templateFile))
            {
                 WithArguments(templateFile);
            }

            return this;
        }

        /// <summary>
        /// Azure key vault name, it not given it will be the cluster resource group name.
        /// </summary>
        public AzureSfClusterCreateTask VaultName(string vaultName = null)
        {
            WithArguments("--vault-name");
            if (!string.IsNullOrEmpty(vaultName))
            {
                 WithArguments(vaultName);
            }

            return this;
        }

        /// <summary>
        /// Key vault resource group name,if not given it will be cluster resource group name.
        /// </summary>
        public AzureSfClusterCreateTask VaultResourceGroup(string vaultResourceGroup = null)
        {
            WithArguments("--vault-resource-group");
            if (!string.IsNullOrEmpty(vaultResourceGroup))
            {
                 WithArguments(vaultResourceGroup);
            }

            return this;
        }

        /// <summary>
        /// The password of the Vm.
        /// </summary>
        public AzureSfClusterCreateTask VmPassword(string vmPassword = null)
        {
            WithArguments("--vm-password");
            if (!string.IsNullOrEmpty(vmPassword))
            {
                 WithArguments(vmPassword);
            }

            return this;
        }

        /// <summary>
        /// The Vm Sku.
        /// </summary>
        public AzureSfClusterCreateTask VmSku(string vmSku = null)
        {
            WithArguments("--vm-sku");
            if (!string.IsNullOrEmpty(vmSku))
            {
                 WithArguments(vmSku);
            }

            return this;
        }

        /// <summary>
        /// The user name for logging to Vm. Default will be adminuser.
        /// </summary>
        public AzureSfClusterCreateTask VmUserName(string vmUserName = null)
        {
            WithArguments("--vm-user-name");
            if (!string.IsNullOrEmpty(vmUserName))
            {
                 WithArguments(vmUserName);
            }

            return this;
        }
     }
}
