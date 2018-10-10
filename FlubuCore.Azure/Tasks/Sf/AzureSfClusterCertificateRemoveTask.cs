
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Sf
{
     public partial class AzureSfClusterCertificateRemoveTask : ExternalProcessTaskBase<AzureSfClusterCertificateRemoveTask>
     {
        
        /// <summary>
        /// Remove a certificate from a cluster.
        /// </summary>
        public AzureSfClusterCertificateRemoveTask(string clusterName = null ,  string resourceGroup = null ,  string thumbprint = null)
        {
            WithArguments("az sf cluster certificate remove");
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

WithArguments("--thumbprint");
            if (!string.IsNullOrEmpty(thumbprint))
            {
                 WithArguments(thumbprint);
            }

        }

        protected override string Description { get; set; }
        
     }
}
