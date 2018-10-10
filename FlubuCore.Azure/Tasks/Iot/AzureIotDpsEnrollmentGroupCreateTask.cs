
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDpsEnrollmentGroupCreateTask : ExternalProcessTaskBase<AzureIotDpsEnrollmentGroupCreateTask>
     {
        
        /// <summary>
        /// Create an enrollment group in an Azure IoT Hub Device Provisioning Service.
        /// </summary>
        public AzureIotDpsEnrollmentGroupCreateTask(string dpsName = null ,  string enrollmentId = null ,  string resourceGroup = null)
        {
            WithArguments("az iot dps enrollment-group create");
WithArguments("--dps-name");
            if (!string.IsNullOrEmpty(dpsName))
            {
                 WithArguments(dpsName);
            }

WithArguments("--enrollment-id");
            if (!string.IsNullOrEmpty(enrollmentId))
            {
                 WithArguments(enrollmentId);
            }

WithArguments("--resource-group");
            if (!string.IsNullOrEmpty(resourceGroup))
            {
                 WithArguments(resourceGroup);
            }

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Type of allocation for device assigned to the Hub.
        /// </summary>
        public AzureIotDpsEnrollmentGroupCreateTask AllocationPolicy(string allocationPolicy = null)
        {
            WithArguments("--allocation-policy");
            if (!string.IsNullOrEmpty(allocationPolicy))
            {
                 WithArguments(allocationPolicy);
            }

            return this;
        }

        /// <summary>
        /// The name of the primary root CA certificate. If attestation with a root CA certificate is desired then a root ca name must be provided.
        /// </summary>
        public AzureIotDpsEnrollmentGroupCreateTask CaName(string caName = null)
        {
            WithArguments("--ca-name");
            if (!string.IsNullOrEmpty(caName))
            {
                 WithArguments(caName);
            }

            return this;
        }

        /// <summary>
        /// The path to the file containing the primary certificate. If attestation with an intermediate certificate is desired then a certificate path must be provided.
        /// </summary>
        public AzureIotDpsEnrollmentGroupCreateTask CertificatePath(string certificatePath = null)
        {
            WithArguments("--certificate-path");
            if (!string.IsNullOrEmpty(certificatePath))
            {
                 WithArguments(certificatePath);
            }

            return this;
        }

        /// <summary>
        /// Host name of target IoT Hub.
        /// </summary>
        public AzureIotDpsEnrollmentGroupCreateTask Hn(string hn = null)
        {
            WithArguments("--hn");
            if (!string.IsNullOrEmpty(hn))
            {
                 WithArguments(hn);
            }

            return this;
        }

        /// <summary>
        /// Host name of target IoT Hub. Use space-separated list for multiple IoT Hubs.
        /// </summary>
        public AzureIotDpsEnrollmentGroupCreateTask Ih(string ih = null)
        {
            WithArguments("--ih");
            if (!string.IsNullOrEmpty(ih))
            {
                 WithArguments(ih);
            }

            return this;
        }

        /// <summary>
        /// Initial twin properties.
        /// </summary>
        public AzureIotDpsEnrollmentGroupCreateTask InitialTwinProperties(string initialTwinProperties = null)
        {
            WithArguments("--initial-twin-properties");
            if (!string.IsNullOrEmpty(initialTwinProperties))
            {
                 WithArguments(initialTwinProperties);
            }

            return this;
        }

        /// <summary>
        /// Initial twin tags.
        /// </summary>
        public AzureIotDpsEnrollmentGroupCreateTask InitialTwinTags(string initialTwinTags = null)
        {
            WithArguments("--initial-twin-tags");
            if (!string.IsNullOrEmpty(initialTwinTags))
            {
                 WithArguments(initialTwinTags);
            }

            return this;
        }

        /// <summary>
        /// The primary symmetric shared access key stored in base64 format.
        /// </summary>
        public AzureIotDpsEnrollmentGroupCreateTask Pk(string pk = null)
        {
            WithArguments("--pk");
            if (!string.IsNullOrEmpty(pk))
            {
                 WithArguments(pk);
            }

            return this;
        }

        /// <summary>
        /// Enable or disable enrollment entry.
        /// </summary>
        public AzureIotDpsEnrollmentGroupCreateTask ProvisioningStatus(string provisioningStatus = null)
        {
            WithArguments("--provisioning-status");
            if (!string.IsNullOrEmpty(provisioningStatus))
            {
                 WithArguments(provisioningStatus);
            }

            return this;
        }

        /// <summary>
        /// Device data to be handled on re-provision to different Iot Hub.
        /// </summary>
        public AzureIotDpsEnrollmentGroupCreateTask ReprovisionPolicy(string reprovisionPolicy = null)
        {
            WithArguments("--reprovision-policy");
            if (!string.IsNullOrEmpty(reprovisionPolicy))
            {
                 WithArguments(reprovisionPolicy);
            }

            return this;
        }

        /// <summary>
        /// The name of the secondary root CA certificate. If attestation with a root CA certificate is desired then a root ca name must be provided.
        /// </summary>
        public AzureIotDpsEnrollmentGroupCreateTask Scn(string scn = null)
        {
            WithArguments("--scn");
            if (!string.IsNullOrEmpty(scn))
            {
                 WithArguments(scn);
            }

            return this;
        }

        /// <summary>
        /// The path to the file containing the secondary certificate. If attestation with an intermediate certificate is desired then a certificate path must be provided.
        /// </summary>
        public AzureIotDpsEnrollmentGroupCreateTask Scp(string scp = null)
        {
            WithArguments("--scp");
            if (!string.IsNullOrEmpty(scp))
            {
                 WithArguments(scp);
            }

            return this;
        }

        /// <summary>
        /// The secondary symmetric shared access key stored in base64 format.
        /// </summary>
        public AzureIotDpsEnrollmentGroupCreateTask SecondaryKey(string secondaryKey = null)
        {
            WithArguments("--secondary-key");
            if (!string.IsNullOrEmpty(secondaryKey))
            {
                 WithArguments(secondaryKey);
            }

            return this;
        }
     }
}
