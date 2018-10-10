
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfApplicationCertificateAddTask : ExternalProcessTaskBase<AzureSfApplicationCertificateAddTask>
     {
        
        /// <summary>
        /// Add a new certificate to the Virtual Machine Scale Sets that make up the cluster to be used by hosted applications.
        /// </summary>
        public AzureSfApplicationCertificateAddTask(string clusterName = null ,  string resourceGroup = null)
        {
            WithArguments("az sf application certificate add");
WithArguments("--cluster-name");
            if (!string.IsNullOrEmpty(clusterName))
            {
                 WithArguments(clusterName);
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
        public AzureSfApplicationCertificateAddTask CertificateFile(string certificateFile = null)
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
        public AzureSfApplicationCertificateAddTask CertificateOutputFolder(string certificateOutputFolder = null)
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
        public AzureSfApplicationCertificateAddTask CertificatePassword(string certificatePassword = null)
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
        public AzureSfApplicationCertificateAddTask CertificateSubjectName(string certificateSubjectName = null)
        {
            WithArguments("--certificate-subject-name");
            if (!string.IsNullOrEmpty(certificateSubjectName))
            {
                 WithArguments(certificateSubjectName);
            }

            return this;
        }

        /// <summary>
        /// The existing Azure key vault secret URL.
        /// </summary>
        public AzureSfApplicationCertificateAddTask SecretIdentifier(string secretIdentifier = null)
        {
            WithArguments("--secret-identifier");
            if (!string.IsNullOrEmpty(secretIdentifier))
            {
                 WithArguments(secretIdentifier);
            }

            return this;
        }

        /// <summary>
        /// Azure key vault name, it not given it will be the cluster resource group name.
        /// </summary>
        public AzureSfApplicationCertificateAddTask VaultName(string vaultName = null)
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
        public AzureSfApplicationCertificateAddTask VaultResourceGroup(string vaultResourceGroup = null)
        {
            WithArguments("--vault-resource-group");
            if (!string.IsNullOrEmpty(vaultResourceGroup))
            {
                 WithArguments(vaultResourceGroup);
            }

            return this;
        }
     }
}
