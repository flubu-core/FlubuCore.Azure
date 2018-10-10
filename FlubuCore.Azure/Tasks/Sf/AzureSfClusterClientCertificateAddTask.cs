
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfClusterClientCertificateAddTask : ExternalProcessTaskBase<AzureSfClusterClientCertificateAddTask>
     {
        
        /// <summary>
        /// Add a common name or certificate thumbprint to the cluster for client authentication.
        /// </summary>
        public AzureSfClusterClientCertificateAddTask(string clusterName = null ,  string resourceGroup = null)
        {
            WithArguments("az sf cluster client-certificate add");
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
        /// Client certificate thumbprint that only has admin permission.
        /// </summary>
        public AzureSfClusterClientCertificateAddTask AdminClientThumbprints(string adminClientThumbprints = null)
        {
            WithArguments("--admin-client-thumbprints");
            if (!string.IsNullOrEmpty(adminClientThumbprints))
            {
                 WithArguments(adminClientThumbprints);
            }

            return this;
        }

        /// <summary>
        /// Client certificate common name.
        /// </summary>
        public AzureSfClusterClientCertificateAddTask CertificateCommonName(string certificateCommonName = null)
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
        public AzureSfClusterClientCertificateAddTask CertificateIssuerThumbprint(string certificateIssuerThumbprint = null)
        {
            WithArguments("--certificate-issuer-thumbprint");
            if (!string.IsNullOrEmpty(certificateIssuerThumbprint))
            {
                 WithArguments(certificateIssuerThumbprint);
            }

            return this;
        }

        /// <summary>
        /// JSON encoded parameters configuration. Use @{file} to load from a file. For example: [{"isAdmin":true, "certificateCommonName": "test.com", "certificateIssuerThumbprint": "22B4AE296B504E512DF880A77A2CAE20200FF922"}].
        /// </summary>
        public AzureSfClusterClientCertificateAddTask ClientCertificateCommonNames(string clientCertificateCommonNames = null)
        {
            WithArguments("--client-certificate-common-names");
            if (!string.IsNullOrEmpty(clientCertificateCommonNames))
            {
                 WithArguments(clientCertificateCommonNames);
            }

            return this;
        }

        /// <summary>
        /// Client authentication type.
        /// </summary>
        public AzureSfClusterClientCertificateAddTask IsAdmin(string isAdmin = null)
        {
            WithArguments("--is-admin");
            if (!string.IsNullOrEmpty(isAdmin))
            {
                 WithArguments(isAdmin);
            }

            return this;
        }

        /// <summary>
        /// Space-separated list of client certificate thumbprint that has read only permission.
        /// </summary>
        public AzureSfClusterClientCertificateAddTask ReadonlyClientThumbprints(string readonlyClientThumbprints = null)
        {
            WithArguments("--readonly-client-thumbprints");
            if (!string.IsNullOrEmpty(readonlyClientThumbprints))
            {
                 WithArguments(readonlyClientThumbprints);
            }

            return this;
        }

        /// <summary>
        /// Client certificate thumbprint.
        /// </summary>
        public AzureSfClusterClientCertificateAddTask Thumbprint(string thumbprint = null)
        {
            WithArguments("--thumbprint");
            if (!string.IsNullOrEmpty(thumbprint))
            {
                 WithArguments(thumbprint);
            }

            return this;
        }
     }
}
