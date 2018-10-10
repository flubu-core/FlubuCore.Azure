
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfClusterClientCertificateRemoveTask : ExternalProcessTaskBase<AzureSfClusterClientCertificateRemoveTask>
     {
        
        /// <summary>
        /// Remove client certificates or subject names used for authentication.
        /// </summary>
        public AzureSfClusterClientCertificateRemoveTask(string clusterName = null ,  string resourceGroup = null)
        {
            WithArguments("az sf cluster client-certificate remove");
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
        /// Client certificate common name.
        /// </summary>
        public AzureSfClusterClientCertificateRemoveTask CertificateCommonName(string certificateCommonName = null)
        {
            WithArguments("--certificate-common-name");
            if (!string.IsNullOrEmpty(certificateCommonName))
            {
                 WithArguments(certificateCommonName);
            }

            return this;
        }

        /// <summary>
        /// Client certificate issuer thumbprint.
        /// </summary>
        public AzureSfClusterClientCertificateRemoveTask CertificateIssuerThumbprint(string certificateIssuerThumbprint = null)
        {
            WithArguments("--certificate-issuer-thumbprint");
            if (!string.IsNullOrEmpty(certificateIssuerThumbprint))
            {
                 WithArguments(certificateIssuerThumbprint);
            }

            return this;
        }

        /// <summary>
        /// JSON encoded parameters configuration. Use @{file} to load from a file. For example: [{"certificateCommonName": "test.com","certificateIssuerThumbprint": "22B4AE296B504E512DF880A77A2CAE20200FF922"}].
        /// </summary>
        public AzureSfClusterClientCertificateRemoveTask ClientCertificateCommonNames(string clientCertificateCommonNames = null)
        {
            WithArguments("--client-certificate-common-names");
            if (!string.IsNullOrEmpty(clientCertificateCommonNames))
            {
                 WithArguments(clientCertificateCommonNames);
            }

            return this;
        }

        /// <summary>
        /// A single or Space-separated list of client certificate thumbprint(s) to be remove.
        /// </summary>
        public AzureSfClusterClientCertificateRemoveTask Thumbprints(string thumbprints = null)
        {
            WithArguments("--thumbprints");
            if (!string.IsNullOrEmpty(thumbprints))
            {
                 WithArguments(thumbprints);
            }

            return this;
        }
     }
}
