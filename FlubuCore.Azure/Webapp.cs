
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Webapp;

namespace FlubuCore.Azure
{
    public class Webapp
    {
        
        
            public AzureWebappBrowseTask WebappBrowse(string name ,  string resourceGroup)
            {
                return new AzureWebappBrowseTask(name,  resourceGroup);
            }

            public AzureWebappCreateTask WebappCreate(string name ,  string plan ,  string resourceGroup)
            {
                return new AzureWebappCreateTask(name,  plan,  resourceGroup);
            }

            public AzureWebappDeleteTask WebappDelete(string name ,  string resourceGroup)
            {
                return new AzureWebappDeleteTask(name,  resourceGroup);
            }

            public AzureWebappRestartTask WebappRestart(string name ,  string resourceGroup)
            {
                return new AzureWebappRestartTask(name,  resourceGroup);
            }

            public AzureWebappStartTask WebappStart(string name ,  string resourceGroup)
            {
                return new AzureWebappStartTask(name,  resourceGroup);
            }

            public AzureWebappStopTask WebappStop(string name ,  string resourceGroup)
            {
                return new AzureWebappStopTask(name,  resourceGroup);
            }

            public AzureWebappUpdateTask WebappUpdate(string name ,  string resourceGroup)
            {
                return new AzureWebappUpdateTask(name,  resourceGroup);
            }

            public AzureWebappUpTask WebappUp(string name)
            {
                return new AzureWebappUpTask(name);
            }

            public AzureWebappRemoteConnectionTask WebappRemoteConnection()
            {
                return new AzureWebappRemoteConnectionTask();
            }

            public AzureWebappRemoteConnectionCreateTask WebappRemoteConnectionCreate(string name ,  string resourceGroup)
            {
                return new AzureWebappRemoteConnectionCreateTask(name,  resourceGroup);
            }

            public AzureWebappAuthTask WebappAuth()
            {
                return new AzureWebappAuthTask();
            }

            public AzureWebappAuthUpdateTask WebappAuthUpdate(string name ,  string resourceGroup)
            {
                return new AzureWebappAuthUpdateTask(name,  resourceGroup);
            }

            public AzureWebappConfigTask WebappConfig()
            {
                return new AzureWebappConfigTask();
            }

            public AzureWebappConfigSetTask WebappConfigSet(string name ,  string resourceGroup)
            {
                return new AzureWebappConfigSetTask(name,  resourceGroup);
            }

            public AzureWebappCorsTask WebappCors()
            {
                return new AzureWebappCorsTask();
            }

            public AzureWebappCorsAddTask WebappCorsAdd(string allowedOrigins ,  string name ,  string resourceGroup)
            {
                return new AzureWebappCorsAddTask(allowedOrigins,  name,  resourceGroup);
            }

            public AzureWebappCorsRemoveTask WebappCorsRemove(string allowedOrigins ,  string name ,  string resourceGroup)
            {
                return new AzureWebappCorsRemoveTask(allowedOrigins,  name,  resourceGroup);
            }

            public AzureWebappDeletedTask WebappDeleted()
            {
                return new AzureWebappDeletedTask();
            }

            public AzureWebappDeletedRestoreTask WebappDeletedRestore(string deletedId ,  string name ,  string resourceGroup)
            {
                return new AzureWebappDeletedRestoreTask(deletedId,  name,  resourceGroup);
            }

            public AzureWebappDeploymentTask WebappDeployment()
            {
                return new AzureWebappDeploymentTask();
            }

            public AzureWebappIdentityTask WebappIdentity()
            {
                return new AzureWebappIdentityTask();
            }

            public AzureWebappIdentityAssignTask WebappIdentityAssign(string name ,  string resourceGroup)
            {
                return new AzureWebappIdentityAssignTask(name,  resourceGroup);
            }

            public AzureWebappIdentityRemoveTask WebappIdentityRemove(string name ,  string resourceGroup)
            {
                return new AzureWebappIdentityRemoveTask(name,  resourceGroup);
            }

            public AzureWebappLogTask WebappLog()
            {
                return new AzureWebappLogTask();
            }

            public AzureWebappLogConfigTask WebappLogConfig(string name ,  string resourceGroup)
            {
                return new AzureWebappLogConfigTask(name,  resourceGroup);
            }

            public AzureWebappLogDownloadTask WebappLogDownload(string name ,  string resourceGroup)
            {
                return new AzureWebappLogDownloadTask(name,  resourceGroup);
            }

            public AzureWebappLogTailTask WebappLogTail(string name ,  string resourceGroup)
            {
                return new AzureWebappLogTailTask(name,  resourceGroup);
            }

            public AzureWebappTrafficRoutingTask WebappTrafficRouting()
            {
                return new AzureWebappTrafficRoutingTask();
            }

            public AzureWebappTrafficRoutingClearTask WebappTrafficRoutingClear(string name ,  string resourceGroup)
            {
                return new AzureWebappTrafficRoutingClearTask(name,  resourceGroup);
            }

            public AzureWebappTrafficRoutingSetTask WebappTrafficRoutingSet(string distribution ,  string name ,  string resourceGroup)
            {
                return new AzureWebappTrafficRoutingSetTask(distribution,  name,  resourceGroup);
            }

            public AzureWebappWebjobTask WebappWebjob()
            {
                return new AzureWebappWebjobTask();
            }

            public AzureWebappConfigAppsettingsTask WebappConfigAppsettings()
            {
                return new AzureWebappConfigAppsettingsTask();
            }

            public AzureWebappConfigAppsettingsDeleteTask WebappConfigAppsettingsDelete(string name ,  string resourceGroup ,  string settingNames)
            {
                return new AzureWebappConfigAppsettingsDeleteTask(name,  resourceGroup,  settingNames);
            }

            public AzureWebappConfigAppsettingsSetTask WebappConfigAppsettingsSet(string name ,  string resourceGroup)
            {
                return new AzureWebappConfigAppsettingsSetTask(name,  resourceGroup);
            }

            public AzureWebappConfigBackupTask WebappConfigBackup()
            {
                return new AzureWebappConfigBackupTask();
            }

            public AzureWebappConfigBackupCreateTask WebappConfigBackupCreate(string containerUrl ,  string resourceGroup ,  string webappName)
            {
                return new AzureWebappConfigBackupCreateTask(containerUrl,  resourceGroup,  webappName);
            }

            public AzureWebappConfigBackupRestoreTask WebappConfigBackupRestore(string backupName ,  string containerUrl ,  string resourceGroup ,  string webappName)
            {
                return new AzureWebappConfigBackupRestoreTask(backupName,  containerUrl,  resourceGroup,  webappName);
            }

            public AzureWebappConfigBackupUpdateTask WebappConfigBackupUpdate(string resourceGroup ,  string webappName)
            {
                return new AzureWebappConfigBackupUpdateTask(resourceGroup,  webappName);
            }

            public AzureWebappConfigConnectionStringTask WebappConfigConnectionString()
            {
                return new AzureWebappConfigConnectionStringTask();
            }

            public AzureWebappConfigConnectionStringDeleteTask WebappConfigConnectionStringDelete(string name ,  string resourceGroup ,  string settingNames)
            {
                return new AzureWebappConfigConnectionStringDeleteTask(name,  resourceGroup,  settingNames);
            }

            public AzureWebappConfigConnectionStringSetTask WebappConfigConnectionStringSet(string connectionStringType ,  string name ,  string resourceGroup)
            {
                return new AzureWebappConfigConnectionStringSetTask(connectionStringType,  name,  resourceGroup);
            }

            public AzureWebappConfigContainerTask WebappConfigContainer()
            {
                return new AzureWebappConfigContainerTask();
            }

            public AzureWebappConfigContainerDeleteTask WebappConfigContainerDelete(string name ,  string resourceGroup)
            {
                return new AzureWebappConfigContainerDeleteTask(name,  resourceGroup);
            }

            public AzureWebappConfigContainerSetTask WebappConfigContainerSet(string name ,  string resourceGroup)
            {
                return new AzureWebappConfigContainerSetTask(name,  resourceGroup);
            }

            public AzureWebappConfigHostnameTask WebappConfigHostname()
            {
                return new AzureWebappConfigHostnameTask();
            }

            public AzureWebappConfigHostnameAddTask WebappConfigHostnameAdd(string hostname ,  string resourceGroup ,  string webappName)
            {
                return new AzureWebappConfigHostnameAddTask(hostname,  resourceGroup,  webappName);
            }

            public AzureWebappConfigHostnameDeleteTask WebappConfigHostnameDelete(string hostname ,  string resourceGroup ,  string webappName)
            {
                return new AzureWebappConfigHostnameDeleteTask(hostname,  resourceGroup,  webappName);
            }

            public AzureWebappConfigHostnameGetExternalIpTask WebappConfigHostnameGetExternalIp(string resourceGroup ,  string webappName)
            {
                return new AzureWebappConfigHostnameGetExternalIpTask(resourceGroup,  webappName);
            }

            public AzureWebappConfigSslTask WebappConfigSsl()
            {
                return new AzureWebappConfigSslTask();
            }

            public AzureWebappConfigSslBindTask WebappConfigSslBind(string certificateThumbprint ,  string name ,  string resourceGroup ,  string sslType)
            {
                return new AzureWebappConfigSslBindTask(certificateThumbprint,  name,  resourceGroup,  sslType);
            }

            public AzureWebappConfigSslDeleteTask WebappConfigSslDelete(string certificateThumbprint ,  string resourceGroup)
            {
                return new AzureWebappConfigSslDeleteTask(certificateThumbprint,  resourceGroup);
            }

            public AzureWebappConfigSslUnbindTask WebappConfigSslUnbind(string certificateThumbprint ,  string name ,  string resourceGroup)
            {
                return new AzureWebappConfigSslUnbindTask(certificateThumbprint,  name,  resourceGroup);
            }

            public AzureWebappConfigSslUploadTask WebappConfigSslUpload(string certificateFile ,  string certificatePassword ,  string name ,  string resourceGroup)
            {
                return new AzureWebappConfigSslUploadTask(certificateFile,  certificatePassword,  name,  resourceGroup);
            }

            public AzureWebappConfigStorageAccountTask WebappConfigStorageAccount()
            {
                return new AzureWebappConfigStorageAccountTask();
            }

            public AzureWebappConfigStorageAccountAddTask WebappConfigStorageAccountAdd(string accessKey ,  string accountName ,  string customId ,  string name ,  string resourceGroup ,  string shareName ,  string storageType)
            {
                return new AzureWebappConfigStorageAccountAddTask(accessKey,  accountName,  customId,  name,  resourceGroup,  shareName,  storageType);
            }

            public AzureWebappConfigStorageAccountDeleteTask WebappConfigStorageAccountDelete(string customId ,  string name ,  string resourceGroup)
            {
                return new AzureWebappConfigStorageAccountDeleteTask(customId,  name,  resourceGroup);
            }

            public AzureWebappConfigStorageAccountUpdateTask WebappConfigStorageAccountUpdate(string customId ,  string name ,  string resourceGroup)
            {
                return new AzureWebappConfigStorageAccountUpdateTask(customId,  name,  resourceGroup);
            }

            public AzureWebappDeploymentContainerTask WebappDeploymentContainer()
            {
                return new AzureWebappDeploymentContainerTask();
            }

            public AzureWebappDeploymentContainerConfigTask WebappDeploymentContainerConfig(string enableCd ,  string name ,  string resourceGroup)
            {
                return new AzureWebappDeploymentContainerConfigTask(enableCd,  name,  resourceGroup);
            }

            public AzureWebappDeploymentSlotTask WebappDeploymentSlot()
            {
                return new AzureWebappDeploymentSlotTask();
            }

            public AzureWebappDeploymentSlotAutoSwapTask WebappDeploymentSlotAutoSwap(string name ,  string resourceGroup ,  string slot)
            {
                return new AzureWebappDeploymentSlotAutoSwapTask(name,  resourceGroup,  slot);
            }

            public AzureWebappDeploymentSlotCreateTask WebappDeploymentSlotCreate(string name ,  string resourceGroup ,  string slot)
            {
                return new AzureWebappDeploymentSlotCreateTask(name,  resourceGroup,  slot);
            }

            public AzureWebappDeploymentSlotDeleteTask WebappDeploymentSlotDelete(string name ,  string resourceGroup ,  string slot)
            {
                return new AzureWebappDeploymentSlotDeleteTask(name,  resourceGroup,  slot);
            }

            public AzureWebappDeploymentSlotSwapTask WebappDeploymentSlotSwap(string name ,  string resourceGroup ,  string slot)
            {
                return new AzureWebappDeploymentSlotSwapTask(name,  resourceGroup,  slot);
            }

            public AzureWebappDeploymentSourceTask WebappDeploymentSource()
            {
                return new AzureWebappDeploymentSourceTask();
            }

            public AzureWebappDeploymentSourceConfigTask WebappDeploymentSourceConfig(string name ,  string repoUrl ,  string resourceGroup)
            {
                return new AzureWebappDeploymentSourceConfigTask(name,  repoUrl,  resourceGroup);
            }

            public AzureWebappDeploymentSourceConfigLocalGitTask WebappDeploymentSourceConfigLocalGit(string name ,  string resourceGroup)
            {
                return new AzureWebappDeploymentSourceConfigLocalGitTask(name,  resourceGroup);
            }

            public AzureWebappDeploymentSourceConfigZipTask WebappDeploymentSourceConfigZip(string name ,  string resourceGroup ,  string src)
            {
                return new AzureWebappDeploymentSourceConfigZipTask(name,  resourceGroup,  src);
            }

            public AzureWebappDeploymentSourceDeleteTask WebappDeploymentSourceDelete(string name ,  string resourceGroup)
            {
                return new AzureWebappDeploymentSourceDeleteTask(name,  resourceGroup);
            }

            public AzureWebappDeploymentSourceSyncTask WebappDeploymentSourceSync(string name ,  string resourceGroup)
            {
                return new AzureWebappDeploymentSourceSyncTask(name,  resourceGroup);
            }

            public AzureWebappDeploymentSourceUpdateTokenTask WebappDeploymentSourceUpdateToken()
            {
                return new AzureWebappDeploymentSourceUpdateTokenTask();
            }

            public AzureWebappDeploymentUserTask WebappDeploymentUser()
            {
                return new AzureWebappDeploymentUserTask();
            }

            public AzureWebappDeploymentUserSetTask WebappDeploymentUserSet(string userName)
            {
                return new AzureWebappDeploymentUserSetTask(userName);
            }

            public AzureWebappWebjobContinuousTask WebappWebjobContinuous()
            {
                return new AzureWebappWebjobContinuousTask();
            }

            public AzureWebappWebjobContinuousRemoveTask WebappWebjobContinuousRemove(string name ,  string resourceGroup ,  string webjobName)
            {
                return new AzureWebappWebjobContinuousRemoveTask(name,  resourceGroup,  webjobName);
            }

            public AzureWebappWebjobContinuousStartTask WebappWebjobContinuousStart(string name ,  string resourceGroup ,  string webjobName)
            {
                return new AzureWebappWebjobContinuousStartTask(name,  resourceGroup,  webjobName);
            }

            public AzureWebappWebjobContinuousStopTask WebappWebjobContinuousStop(string name ,  string resourceGroup ,  string webjobName)
            {
                return new AzureWebappWebjobContinuousStopTask(name,  resourceGroup,  webjobName);
            }

            public AzureWebappWebjobTriggeredTask WebappWebjobTriggered()
            {
                return new AzureWebappWebjobTriggeredTask();
            }

            public AzureWebappWebjobTriggeredLogTask WebappWebjobTriggeredLog(string name ,  string resourceGroup ,  string webjobName)
            {
                return new AzureWebappWebjobTriggeredLogTask(name,  resourceGroup,  webjobName);
            }

            public AzureWebappWebjobTriggeredRemoveTask WebappWebjobTriggeredRemove(string name ,  string resourceGroup ,  string webjobName)
            {
                return new AzureWebappWebjobTriggeredRemoveTask(name,  resourceGroup,  webjobName);
            }

            public AzureWebappWebjobTriggeredRunTask WebappWebjobTriggeredRun(string name ,  string resourceGroup ,  string webjobName)
            {
                return new AzureWebappWebjobTriggeredRunTask(name,  resourceGroup,  webjobName);
            }
        
    }
}

