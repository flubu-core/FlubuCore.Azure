
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Azure.Tasks;
using FlubuCore.Azure.Tasks.Functionapp;

namespace FlubuCore.Azure
{
    public class Functionapp
    {
        
        
            public AzureFunctionappCreateTask FunctionappCreate(string name ,  string resourceGroup ,  string storageAccount)
            {
                return new AzureFunctionappCreateTask(name,  resourceGroup,  storageAccount);
            }

            public AzureFunctionappDeleteTask FunctionappDelete(string name ,  string resourceGroup)
            {
                return new AzureFunctionappDeleteTask(name,  resourceGroup);
            }

            public AzureFunctionappRestartTask FunctionappRestart(string name ,  string resourceGroup)
            {
                return new AzureFunctionappRestartTask(name,  resourceGroup);
            }

            public AzureFunctionappStartTask FunctionappStart(string name ,  string resourceGroup)
            {
                return new AzureFunctionappStartTask(name,  resourceGroup);
            }

            public AzureFunctionappStopTask FunctionappStop(string name ,  string resourceGroup)
            {
                return new AzureFunctionappStopTask(name,  resourceGroup);
            }

            public AzureFunctionappUpdateTask FunctionappUpdate(string name ,  string resourceGroup)
            {
                return new AzureFunctionappUpdateTask(name,  resourceGroup);
            }

            public AzureFunctionappConfigTask FunctionappConfig()
            {
                return new AzureFunctionappConfigTask();
            }

            public AzureFunctionappConfigSetTask FunctionappConfigSet(string name ,  string resourceGroup)
            {
                return new AzureFunctionappConfigSetTask(name,  resourceGroup);
            }

            public AzureFunctionappCorsTask FunctionappCors()
            {
                return new AzureFunctionappCorsTask();
            }

            public AzureFunctionappCorsAddTask FunctionappCorsAdd(string allowedOrigins ,  string name ,  string resourceGroup)
            {
                return new AzureFunctionappCorsAddTask(allowedOrigins,  name,  resourceGroup);
            }

            public AzureFunctionappCorsRemoveTask FunctionappCorsRemove(string allowedOrigins ,  string name ,  string resourceGroup)
            {
                return new AzureFunctionappCorsRemoveTask(allowedOrigins,  name,  resourceGroup);
            }

            public AzureFunctionappDeploymentTask FunctionappDeployment()
            {
                return new AzureFunctionappDeploymentTask();
            }

            public AzureFunctionappIdentityTask FunctionappIdentity()
            {
                return new AzureFunctionappIdentityTask();
            }

            public AzureFunctionappIdentityAssignTask FunctionappIdentityAssign(string name ,  string resourceGroup)
            {
                return new AzureFunctionappIdentityAssignTask(name,  resourceGroup);
            }

            public AzureFunctionappIdentityRemoveTask FunctionappIdentityRemove(string name ,  string resourceGroup)
            {
                return new AzureFunctionappIdentityRemoveTask(name,  resourceGroup);
            }

            public AzureFunctionappConfigAppsettingsTask FunctionappConfigAppsettings()
            {
                return new AzureFunctionappConfigAppsettingsTask();
            }

            public AzureFunctionappConfigAppsettingsDeleteTask FunctionappConfigAppsettingsDelete(string name ,  string resourceGroup ,  string settingNames)
            {
                return new AzureFunctionappConfigAppsettingsDeleteTask(name,  resourceGroup,  settingNames);
            }

            public AzureFunctionappConfigAppsettingsSetTask FunctionappConfigAppsettingsSet(string name ,  string resourceGroup)
            {
                return new AzureFunctionappConfigAppsettingsSetTask(name,  resourceGroup);
            }

            public AzureFunctionappConfigHostnameTask FunctionappConfigHostname()
            {
                return new AzureFunctionappConfigHostnameTask();
            }

            public AzureFunctionappConfigHostnameAddTask FunctionappConfigHostnameAdd(string hostname ,  string name ,  string resourceGroup)
            {
                return new AzureFunctionappConfigHostnameAddTask(hostname,  name,  resourceGroup);
            }

            public AzureFunctionappConfigHostnameDeleteTask FunctionappConfigHostnameDelete(string hostname ,  string name ,  string resourceGroup)
            {
                return new AzureFunctionappConfigHostnameDeleteTask(hostname,  name,  resourceGroup);
            }

            public AzureFunctionappConfigHostnameGetExternalIpTask FunctionappConfigHostnameGetExternalIp(string name ,  string resourceGroup)
            {
                return new AzureFunctionappConfigHostnameGetExternalIpTask(name,  resourceGroup);
            }

            public AzureFunctionappConfigSslTask FunctionappConfigSsl()
            {
                return new AzureFunctionappConfigSslTask();
            }

            public AzureFunctionappConfigSslBindTask FunctionappConfigSslBind(string certificateThumbprint ,  string name ,  string resourceGroup ,  string sslType)
            {
                return new AzureFunctionappConfigSslBindTask(certificateThumbprint,  name,  resourceGroup,  sslType);
            }

            public AzureFunctionappConfigSslDeleteTask FunctionappConfigSslDelete(string certificateThumbprint ,  string resourceGroup)
            {
                return new AzureFunctionappConfigSslDeleteTask(certificateThumbprint,  resourceGroup);
            }

            public AzureFunctionappConfigSslUnbindTask FunctionappConfigSslUnbind(string certificateThumbprint ,  string name ,  string resourceGroup)
            {
                return new AzureFunctionappConfigSslUnbindTask(certificateThumbprint,  name,  resourceGroup);
            }

            public AzureFunctionappConfigSslUploadTask FunctionappConfigSslUpload(string certificateFile ,  string certificatePassword ,  string name ,  string resourceGroup)
            {
                return new AzureFunctionappConfigSslUploadTask(certificateFile,  certificatePassword,  name,  resourceGroup);
            }

            public AzureFunctionappDeploymentSourceTask FunctionappDeploymentSource()
            {
                return new AzureFunctionappDeploymentSourceTask();
            }

            public AzureFunctionappDeploymentSourceConfigTask FunctionappDeploymentSourceConfig(string name ,  string repoUrl ,  string resourceGroup)
            {
                return new AzureFunctionappDeploymentSourceConfigTask(name,  repoUrl,  resourceGroup);
            }

            public AzureFunctionappDeploymentSourceConfigLocalGitTask FunctionappDeploymentSourceConfigLocalGit(string name ,  string resourceGroup)
            {
                return new AzureFunctionappDeploymentSourceConfigLocalGitTask(name,  resourceGroup);
            }

            public AzureFunctionappDeploymentSourceConfigZipTask FunctionappDeploymentSourceConfigZip(string name ,  string resourceGroup ,  string src)
            {
                return new AzureFunctionappDeploymentSourceConfigZipTask(name,  resourceGroup,  src);
            }

            public AzureFunctionappDeploymentSourceDeleteTask FunctionappDeploymentSourceDelete(string name ,  string resourceGroup)
            {
                return new AzureFunctionappDeploymentSourceDeleteTask(name,  resourceGroup);
            }

            public AzureFunctionappDeploymentSourceSyncTask FunctionappDeploymentSourceSync(string name ,  string resourceGroup)
            {
                return new AzureFunctionappDeploymentSourceSyncTask(name,  resourceGroup);
            }

            public AzureFunctionappDeploymentSourceUpdateTokenTask FunctionappDeploymentSourceUpdateToken()
            {
                return new AzureFunctionappDeploymentSourceUpdateTokenTask();
            }

            public AzureFunctionappDeploymentUserTask FunctionappDeploymentUser()
            {
                return new AzureFunctionappDeploymentUserTask();
            }

            public AzureFunctionappDeploymentUserSetTask FunctionappDeploymentUserSet(string userName)
            {
                return new AzureFunctionappDeploymentUserSetTask(userName);
            }
        
    }
}

