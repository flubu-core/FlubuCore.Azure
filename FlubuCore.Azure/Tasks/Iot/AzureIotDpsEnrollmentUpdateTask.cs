
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Azure.Tasks.Iot
{
     public partial class AzureIotDpsEnrollmentUpdateTask : ExternalProcessTaskBase<AzureIotDpsEnrollmentUpdateTask>
     {
        
        /// <summary>
        /// Update a device enrollment in an Azure IoT Hub Device Provisioning Service.
        /// </summary>
        public AzureIotDpsEnrollmentUpdateTask(string dpsName = null ,  string enrollmentId = null ,  string resourceGroup = null)
        {
            WithArguments("az iot dps enrollment update");
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
        public AzureIotDpsEnrollmentUpdateTask AllocationPolicy(string allocationPolicy = null)
        {
            WithArguments("--allocation-policy");
            if (!string.IsNullOrEmpty(allocationPolicy))
            {
                 WithArguments(allocationPolicy);
            }

            return this;
        }

        /// <summary>
        /// The path to the file containing the primary certificate.
        /// </summary>
        public AzureIotDpsEnrollmentUpdateTask CertificatePath(string certificatePath = null)
        {
            WithArguments("--certificate-path");
            if (!string.IsNullOrEmpty(certificatePath))
            {
                 WithArguments(certificatePath);
            }

            return this;
        }

        /// <summary>
        /// IoT Hub Device ID.
        /// </summary>
        public AzureIotDpsEnrollmentUpdateTask DeviceId(string deviceId = null)
        {
            WithArguments("--device-id");
            if (!string.IsNullOrEmpty(deviceId))
            {
                 WithArguments(deviceId);
            }

            return this;
        }

        /// <summary>
        /// TPM endorsement key for a TPM device.
        /// </summary>
        public AzureIotDpsEnrollmentUpdateTask Ek(string ek = null)
        {
            WithArguments("--ek");
            if (!string.IsNullOrEmpty(ek))
            {
                 WithArguments(ek);
            }

            return this;
        }

        /// <summary>
        /// Entity tag value.
        /// </summary>
        public AzureIotDpsEnrollmentUpdateTask Etag(string etag = null)
        {
            WithArguments("--etag");
            if (!string.IsNullOrEmpty(etag))
            {
                 WithArguments(etag);
            }

            return this;
        }

        /// <summary>
        /// Host name of target IoT Hub.
        /// </summary>
        public AzureIotDpsEnrollmentUpdateTask Hn(string hn = null)
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
        public AzureIotDpsEnrollmentUpdateTask Ih(string ih = null)
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
        public AzureIotDpsEnrollmentUpdateTask InitialTwinProperties(string initialTwinProperties = null)
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
        public AzureIotDpsEnrollmentUpdateTask InitialTwinTags(string initialTwinTags = null)
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
        public AzureIotDpsEnrollmentUpdateTask Pk(string pk = null)
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
        public AzureIotDpsEnrollmentUpdateTask ProvisioningStatus(string provisioningStatus = null)
        {
            WithArguments("--provisioning-status");
            if (!string.IsNullOrEmpty(provisioningStatus))
            {
                 WithArguments(provisioningStatus);
            }

            return this;
        }

        /// <summary>
        /// Remove current primary certificate.
        /// </summary>
        public AzureIotDpsEnrollmentUpdateTask Rc(string rc = null)
        {
            WithArguments("--rc");
            if (!string.IsNullOrEmpty(rc))
            {
                 WithArguments(rc);
            }

            return this;
        }

        /// <summary>
        /// Remove current secondary certificate.
        /// </summary>
        public AzureIotDpsEnrollmentUpdateTask RemoveSecondaryCertificate(string removeSecondaryCertificate = null)
        {
            WithArguments("--remove-secondary-certificate");
            if (!string.IsNullOrEmpty(removeSecondaryCertificate))
            {
                 WithArguments(removeSecondaryCertificate);
            }

            return this;
        }

        /// <summary>
        /// Device data to be handled on re-provision to different Iot Hub.
        /// </summary>
        public AzureIotDpsEnrollmentUpdateTask ReprovisionPolicy(string reprovisionPolicy = null)
        {
            WithArguments("--reprovision-policy");
            if (!string.IsNullOrEmpty(reprovisionPolicy))
            {
                 WithArguments(reprovisionPolicy);
            }

            return this;
        }

        /// <summary>
        /// The path to the file containing the secondary certificate.
        /// </summary>
        public AzureIotDpsEnrollmentUpdateTask Scp(string scp = null)
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
        public AzureIotDpsEnrollmentUpdateTask SecondaryKey(string secondaryKey = null)
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
