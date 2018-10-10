
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Iot;

namespace FlubuCore.Azure
{
    public class Iot
    {
        
        
            public AzureIotDeviceTask IotDevice()
            {
                return new AzureIotDeviceTask();
            }

            public AzureIotDeviceSendD2cMessageTask IotDeviceSendD2cMessage(string deviceId)
            {
                return new AzureIotDeviceSendD2cMessageTask(deviceId);
            }

            public AzureIotDeviceSimulateTask IotDeviceSimulate(string deviceId)
            {
                return new AzureIotDeviceSimulateTask(deviceId);
            }

            public AzureIotDeviceUploadFileTask IotDeviceUploadFile(string contentType ,  string deviceId ,  string filePath)
            {
                return new AzureIotDeviceUploadFileTask(contentType,  deviceId,  filePath);
            }

            public AzureIotDpsTask IotDps()
            {
                return new AzureIotDpsTask();
            }

            public AzureIotEdgeTask IotEdge()
            {
                return new AzureIotEdgeTask();
            }

            public AzureIotEdgeSetModulesTask IotEdgeSetModules(string content ,  string deviceId)
            {
                return new AzureIotEdgeSetModulesTask(content,  deviceId);
            }

            public AzureIotHubTask IotHub()
            {
                return new AzureIotHubTask();
            }

            public AzureIotHubApplyConfigurationTask IotHubApplyConfiguration(string content ,  string deviceId)
            {
                return new AzureIotHubApplyConfigurationTask(content,  deviceId);
            }

            public AzureIotHubGenerateSasTokenTask IotHubGenerateSasToken()
            {
                return new AzureIotHubGenerateSasTokenTask();
            }

            public AzureIotHubInvokeDeviceMethodTask IotHubInvokeDeviceMethod(string deviceId ,  string methodName)
            {
                return new AzureIotHubInvokeDeviceMethodTask(deviceId,  methodName);
            }

            public AzureIotHubInvokeModuleMethodTask IotHubInvokeModuleMethod(string deviceId ,  string methodName ,  string moduleId)
            {
                return new AzureIotHubInvokeModuleMethodTask(deviceId,  methodName,  moduleId);
            }

            public AzureIotHubMonitorEventsTask IotHubMonitorEvents()
            {
                return new AzureIotHubMonitorEventsTask();
            }

            public AzureIotHubMonitorFeedbackTask IotHubMonitorFeedback()
            {
                return new AzureIotHubMonitorFeedbackTask();
            }

            public AzureIotHubQueryTask IotHubQuery(string queryCommand)
            {
                return new AzureIotHubQueryTask(queryCommand);
            }

            public AzureIotDeviceC2dMessageTask IotDeviceC2dMessage()
            {
                return new AzureIotDeviceC2dMessageTask();
            }

            public AzureIotDeviceC2dMessageAbandonTask IotDeviceC2dMessageAbandon(string deviceId ,  string etag)
            {
                return new AzureIotDeviceC2dMessageAbandonTask(deviceId,  etag);
            }

            public AzureIotDeviceC2dMessageCompleteTask IotDeviceC2dMessageComplete(string deviceId ,  string etag)
            {
                return new AzureIotDeviceC2dMessageCompleteTask(deviceId,  etag);
            }

            public AzureIotDeviceC2dMessageReceiveTask IotDeviceC2dMessageReceive(string deviceId)
            {
                return new AzureIotDeviceC2dMessageReceiveTask(deviceId);
            }

            public AzureIotDeviceC2dMessageRejectTask IotDeviceC2dMessageReject(string deviceId ,  string etag)
            {
                return new AzureIotDeviceC2dMessageRejectTask(deviceId,  etag);
            }

            public AzureIotDeviceC2dMessageSendTask IotDeviceC2dMessageSend(string deviceId)
            {
                return new AzureIotDeviceC2dMessageSendTask(deviceId);
            }

            public AzureIotDpsEnrollmentGroupTask IotDpsEnrollmentGroup()
            {
                return new AzureIotDpsEnrollmentGroupTask();
            }

            public AzureIotDpsEnrollmentGroupCreateTask IotDpsEnrollmentGroupCreate(string dpsName ,  string enrollmentId ,  string resourceGroup)
            {
                return new AzureIotDpsEnrollmentGroupCreateTask(dpsName,  enrollmentId,  resourceGroup);
            }

            public AzureIotDpsEnrollmentGroupDeleteTask IotDpsEnrollmentGroupDelete(string dpsName ,  string enrollmentId ,  string resourceGroup)
            {
                return new AzureIotDpsEnrollmentGroupDeleteTask(dpsName,  enrollmentId,  resourceGroup);
            }

            public AzureIotDpsEnrollmentGroupUpdateTask IotDpsEnrollmentGroupUpdate(string dpsName ,  string enrollmentId ,  string resourceGroup)
            {
                return new AzureIotDpsEnrollmentGroupUpdateTask(dpsName,  enrollmentId,  resourceGroup);
            }

            public AzureIotDpsEnrollmentTask IotDpsEnrollment()
            {
                return new AzureIotDpsEnrollmentTask();
            }

            public AzureIotDpsEnrollmentCreateTask IotDpsEnrollmentCreate(string at ,  string dpsName ,  string enrollmentId ,  string resourceGroup)
            {
                return new AzureIotDpsEnrollmentCreateTask(at,  dpsName,  enrollmentId,  resourceGroup);
            }

            public AzureIotDpsEnrollmentDeleteTask IotDpsEnrollmentDelete(string dpsName ,  string enrollmentId ,  string resourceGroup)
            {
                return new AzureIotDpsEnrollmentDeleteTask(dpsName,  enrollmentId,  resourceGroup);
            }

            public AzureIotDpsEnrollmentUpdateTask IotDpsEnrollmentUpdate(string dpsName ,  string enrollmentId ,  string resourceGroup)
            {
                return new AzureIotDpsEnrollmentUpdateTask(dpsName,  enrollmentId,  resourceGroup);
            }

            public AzureIotDpsRegistrationTask IotDpsRegistration()
            {
                return new AzureIotDpsRegistrationTask();
            }

            public AzureIotDpsRegistrationDeleteTask IotDpsRegistrationDelete(string dpsName ,  string registrationId ,  string resourceGroup)
            {
                return new AzureIotDpsRegistrationDeleteTask(dpsName,  registrationId,  resourceGroup);
            }

            public AzureIotEdgeDeploymentTask IotEdgeDeployment()
            {
                return new AzureIotEdgeDeploymentTask();
            }

            public AzureIotEdgeDeploymentCreateTask IotEdgeDeploymentCreate(string configId ,  string content)
            {
                return new AzureIotEdgeDeploymentCreateTask(configId,  content);
            }

            public AzureIotEdgeDeploymentDeleteTask IotEdgeDeploymentDelete(string configId)
            {
                return new AzureIotEdgeDeploymentDeleteTask(configId);
            }

            public AzureIotEdgeDeploymentUpdateTask IotEdgeDeploymentUpdate(string configId)
            {
                return new AzureIotEdgeDeploymentUpdateTask(configId);
            }

            public AzureIotHubConfigurationTask IotHubConfiguration()
            {
                return new AzureIotHubConfigurationTask();
            }

            public AzureIotHubConfigurationCreateTask IotHubConfigurationCreate(string configId ,  string content)
            {
                return new AzureIotHubConfigurationCreateTask(configId,  content);
            }

            public AzureIotHubConfigurationDeleteTask IotHubConfigurationDelete(string configId)
            {
                return new AzureIotHubConfigurationDeleteTask(configId);
            }

            public AzureIotHubConfigurationUpdateTask IotHubConfigurationUpdate(string configId)
            {
                return new AzureIotHubConfigurationUpdateTask(configId);
            }

            public AzureIotHubDeviceIdentityTask IotHubDeviceIdentity()
            {
                return new AzureIotHubDeviceIdentityTask();
            }

            public AzureIotHubDeviceIdentityCreateTask IotHubDeviceIdentityCreate(string deviceId)
            {
                return new AzureIotHubDeviceIdentityCreateTask(deviceId);
            }

            public AzureIotHubDeviceIdentityDeleteTask IotHubDeviceIdentityDelete(string deviceId)
            {
                return new AzureIotHubDeviceIdentityDeleteTask(deviceId);
            }

            public AzureIotHubDeviceIdentityExportTask IotHubDeviceIdentityExport(string bcu ,  string hubName)
            {
                return new AzureIotHubDeviceIdentityExportTask(bcu,  hubName);
            }

            public AzureIotHubDeviceIdentityImportTask IotHubDeviceIdentityImport(string hubName ,  string ibcu ,  string obcu)
            {
                return new AzureIotHubDeviceIdentityImportTask(hubName,  ibcu,  obcu);
            }

            public AzureIotHubDeviceIdentityUpdateTask IotHubDeviceIdentityUpdate(string deviceId)
            {
                return new AzureIotHubDeviceIdentityUpdateTask(deviceId);
            }

            public AzureIotHubDeviceTwinTask IotHubDeviceTwin()
            {
                return new AzureIotHubDeviceTwinTask();
            }

            public AzureIotHubDeviceTwinReplaceTask IotHubDeviceTwinReplace(string deviceId ,  string json)
            {
                return new AzureIotHubDeviceTwinReplaceTask(deviceId,  json);
            }

            public AzureIotHubDeviceTwinUpdateTask IotHubDeviceTwinUpdate(string deviceId)
            {
                return new AzureIotHubDeviceTwinUpdateTask(deviceId);
            }

            public AzureIotHubModuleIdentityTask IotHubModuleIdentity()
            {
                return new AzureIotHubModuleIdentityTask();
            }

            public AzureIotHubModuleIdentityCreateTask IotHubModuleIdentityCreate(string deviceId ,  string moduleId)
            {
                return new AzureIotHubModuleIdentityCreateTask(deviceId,  moduleId);
            }

            public AzureIotHubModuleIdentityDeleteTask IotHubModuleIdentityDelete(string deviceId ,  string moduleId)
            {
                return new AzureIotHubModuleIdentityDeleteTask(deviceId,  moduleId);
            }

            public AzureIotHubModuleIdentityUpdateTask IotHubModuleIdentityUpdate(string deviceId ,  string moduleId)
            {
                return new AzureIotHubModuleIdentityUpdateTask(deviceId,  moduleId);
            }

            public AzureIotHubModuleTwinTask IotHubModuleTwin()
            {
                return new AzureIotHubModuleTwinTask();
            }

            public AzureIotHubModuleTwinReplaceTask IotHubModuleTwinReplace(string deviceId ,  string json ,  string moduleId)
            {
                return new AzureIotHubModuleTwinReplaceTask(deviceId,  json,  moduleId);
            }

            public AzureIotHubModuleTwinUpdateTask IotHubModuleTwinUpdate(string deviceId ,  string moduleId)
            {
                return new AzureIotHubModuleTwinUpdateTask(deviceId,  moduleId);
            }

            public AzureIotDpsCreateTask IotDpsCreate(string name ,  string resourceGroup)
            {
                return new AzureIotDpsCreateTask(name,  resourceGroup);
            }

            public AzureIotDpsDeleteTask IotDpsDelete(string name ,  string resourceGroup)
            {
                return new AzureIotDpsDeleteTask(name,  resourceGroup);
            }

            public AzureIotDpsUpdateTask IotDpsUpdate(string name ,  string resourceGroup)
            {
                return new AzureIotDpsUpdateTask(name,  resourceGroup);
            }

            public AzureIotHubCreateTask IotHubCreate(string name ,  string resourceGroup)
            {
                return new AzureIotHubCreateTask(name,  resourceGroup);
            }

            public AzureIotHubDeleteTask IotHubDelete(string name)
            {
                return new AzureIotHubDeleteTask(name);
            }

            public AzureIotHubUpdateTask IotHubUpdate(string name)
            {
                return new AzureIotHubUpdateTask(name);
            }

            public AzureIotDpsAccessPolicyTask IotDpsAccessPolicy()
            {
                return new AzureIotDpsAccessPolicyTask();
            }

            public AzureIotDpsAccessPolicyCreateTask IotDpsAccessPolicyCreate(string accessPolicyName ,  string dpsName ,  string resourceGroup ,  string rights)
            {
                return new AzureIotDpsAccessPolicyCreateTask(accessPolicyName,  dpsName,  resourceGroup,  rights);
            }

            public AzureIotDpsAccessPolicyDeleteTask IotDpsAccessPolicyDelete(string accessPolicyName ,  string dpsName ,  string resourceGroup)
            {
                return new AzureIotDpsAccessPolicyDeleteTask(accessPolicyName,  dpsName,  resourceGroup);
            }

            public AzureIotDpsAccessPolicyUpdateTask IotDpsAccessPolicyUpdate(string accessPolicyName ,  string dpsName ,  string resourceGroup)
            {
                return new AzureIotDpsAccessPolicyUpdateTask(accessPolicyName,  dpsName,  resourceGroup);
            }

            public AzureIotDpsCertificateTask IotDpsCertificate()
            {
                return new AzureIotDpsCertificateTask();
            }

            public AzureIotDpsCertificateCreateTask IotDpsCertificateCreate(string certificateName ,  string dpsName ,  string path ,  string resourceGroup)
            {
                return new AzureIotDpsCertificateCreateTask(certificateName,  dpsName,  path,  resourceGroup);
            }

            public AzureIotDpsCertificateDeleteTask IotDpsCertificateDelete(string certificateName ,  string dpsName ,  string etag ,  string resourceGroup)
            {
                return new AzureIotDpsCertificateDeleteTask(certificateName,  dpsName,  etag,  resourceGroup);
            }

            public AzureIotDpsCertificateGenerateVerificationCodeTask IotDpsCertificateGenerateVerificationCode(string certificateName ,  string dpsName ,  string etag ,  string resourceGroup)
            {
                return new AzureIotDpsCertificateGenerateVerificationCodeTask(certificateName,  dpsName,  etag,  resourceGroup);
            }

            public AzureIotDpsCertificateUpdateTask IotDpsCertificateUpdate(string certificateName ,  string dpsName ,  string etag ,  string path ,  string resourceGroup)
            {
                return new AzureIotDpsCertificateUpdateTask(certificateName,  dpsName,  etag,  path,  resourceGroup);
            }

            public AzureIotDpsCertificateVerifyTask IotDpsCertificateVerify(string certificateName ,  string dpsName ,  string etag ,  string path ,  string resourceGroup)
            {
                return new AzureIotDpsCertificateVerifyTask(certificateName,  dpsName,  etag,  path,  resourceGroup);
            }

            public AzureIotDpsLinkedHubTask IotDpsLinkedHub()
            {
                return new AzureIotDpsLinkedHubTask();
            }

            public AzureIotDpsLinkedHubCreateTask IotDpsLinkedHubCreate(string connectionString ,  string dpsName ,  string location ,  string resourceGroup)
            {
                return new AzureIotDpsLinkedHubCreateTask(connectionString,  dpsName,  location,  resourceGroup);
            }

            public AzureIotDpsLinkedHubDeleteTask IotDpsLinkedHubDelete(string dpsName ,  string linkedHub ,  string resourceGroup)
            {
                return new AzureIotDpsLinkedHubDeleteTask(dpsName,  linkedHub,  resourceGroup);
            }

            public AzureIotDpsLinkedHubUpdateTask IotDpsLinkedHubUpdate(string dpsName ,  string linkedHub ,  string resourceGroup)
            {
                return new AzureIotDpsLinkedHubUpdateTask(dpsName,  linkedHub,  resourceGroup);
            }

            public AzureIotHubCertificateTask IotHubCertificate()
            {
                return new AzureIotHubCertificateTask();
            }

            public AzureIotHubCertificateCreateTask IotHubCertificateCreate(string hubName ,  string name ,  string path)
            {
                return new AzureIotHubCertificateCreateTask(hubName,  name,  path);
            }

            public AzureIotHubCertificateDeleteTask IotHubCertificateDelete(string etag ,  string hubName ,  string name)
            {
                return new AzureIotHubCertificateDeleteTask(etag,  hubName,  name);
            }

            public AzureIotHubCertificateGenerateVerificationCodeTask IotHubCertificateGenerateVerificationCode(string etag ,  string hubName ,  string name)
            {
                return new AzureIotHubCertificateGenerateVerificationCodeTask(etag,  hubName,  name);
            }

            public AzureIotHubCertificateUpdateTask IotHubCertificateUpdate(string etag ,  string hubName ,  string name ,  string path)
            {
                return new AzureIotHubCertificateUpdateTask(etag,  hubName,  name,  path);
            }

            public AzureIotHubCertificateVerifyTask IotHubCertificateVerify(string etag ,  string hubName ,  string name ,  string path)
            {
                return new AzureIotHubCertificateVerifyTask(etag,  hubName,  name,  path);
            }

            public AzureIotHubConsumerGroupTask IotHubConsumerGroup()
            {
                return new AzureIotHubConsumerGroupTask();
            }

            public AzureIotHubConsumerGroupCreateTask IotHubConsumerGroupCreate(string hubName ,  string name)
            {
                return new AzureIotHubConsumerGroupCreateTask(hubName,  name);
            }

            public AzureIotHubConsumerGroupDeleteTask IotHubConsumerGroupDelete(string hubName ,  string name)
            {
                return new AzureIotHubConsumerGroupDeleteTask(hubName,  name);
            }

            public AzureIotHubJobTask IotHubJob()
            {
                return new AzureIotHubJobTask();
            }

            public AzureIotHubJobCancelTask IotHubJobCancel(string hubName ,  string jobId)
            {
                return new AzureIotHubJobCancelTask(hubName,  jobId);
            }

            public AzureIotHubPolicyTask IotHubPolicy()
            {
                return new AzureIotHubPolicyTask();
            }

            public AzureIotHubPolicyCreateTask IotHubPolicyCreate(string hubName ,  string name ,  string permissions)
            {
                return new AzureIotHubPolicyCreateTask(hubName,  name,  permissions);
            }

            public AzureIotHubPolicyDeleteTask IotHubPolicyDelete(string hubName ,  string name)
            {
                return new AzureIotHubPolicyDeleteTask(hubName,  name);
            }

            public AzureIotHubRouteTask IotHubRoute()
            {
                return new AzureIotHubRouteTask();
            }

            public AzureIotHubRouteCreateTask IotHubRouteCreate(string en ,  string hubName ,  string name ,  string source)
            {
                return new AzureIotHubRouteCreateTask(en,  hubName,  name,  source);
            }

            public AzureIotHubRouteDeleteTask IotHubRouteDelete(string hubName)
            {
                return new AzureIotHubRouteDeleteTask(hubName);
            }

            public AzureIotHubRouteTestTask IotHubRouteTest(string hubName)
            {
                return new AzureIotHubRouteTestTask(hubName);
            }

            public AzureIotHubRouteUpdateTask IotHubRouteUpdate(string hubName ,  string name)
            {
                return new AzureIotHubRouteUpdateTask(hubName,  name);
            }

            public AzureIotHubRoutingEndpointTask IotHubRoutingEndpoint()
            {
                return new AzureIotHubRoutingEndpointTask();
            }

            public AzureIotHubRoutingEndpointCreateTask IotHubRoutingEndpointCreate(string connectionString ,  string endpointName ,  string endpointResourceGroup ,  string endpointSubscriptionId ,  string endpointType ,  string hubName)
            {
                return new AzureIotHubRoutingEndpointCreateTask(connectionString,  endpointName,  endpointResourceGroup,  endpointSubscriptionId,  endpointType,  hubName);
            }

            public AzureIotHubRoutingEndpointDeleteTask IotHubRoutingEndpointDelete(string hubName)
            {
                return new AzureIotHubRoutingEndpointDeleteTask(hubName);
            }
        
    }
}

